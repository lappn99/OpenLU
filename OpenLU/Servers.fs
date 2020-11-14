namespace OpenLU
open CoreTypes
open RakDotNet
open System
open System.Net
open Services
open RakDotNet.RakNet
open System.Diagnostics
open System.Linq
open OpenLU.CoreTypes.Enums
open Microsoft.FSharp.Collections
open OpenLU.Models.GameModels
open OpenLU.DBContext
open OpenLU.CoreTypes.LDF
open OpenLU.GameComponent
open OpenLU.CoreTypes
open OpenLU.Zone
open System.Numerics
open OpenLU.GameObject
module rec Servers = 
    type LUServer(port : int, password : string,name : string) =
            let mutable  _server : IRakNetServer = null
            member this.Port with get() = port
            member this.Password with get() = password
            member this.Server with get() = _server and set(v : IRakNetServer) = _server <- v
            member this.Name with get() = name

    type WorldServer(port: int, password: string, name:string) =
        inherit LUServer(port,password,name)
        let mutable _zones : list<zone> = List.empty
        member this.Zones with get() = _zones and set(v) = _zones <- v
            
            
    module LUServer =
        let startServer(server: LUServer) (onReceive) (onNewConnection) (onDisconnect)  = 
            Console.WriteLine("Starting: {0}",server.Name)
            server.Server <- RakNetServer(server.Port,server.Password)
            server.Server.add_PacketReceived(fun (ipep) (data) -> onReceive server ipep data)
            server.Server.add_NewConnection(fun ipep -> onNewConnection server ipep)
            server.Server.add_Disconnection(fun ipep -> onDisconnect server ipep)
            server.Server.Start()
        let startServerAsync (server: LUServer) (onReceive) (onNewConnection) (onDisconnect) =
            async{
                LUServer.startServer server onReceive onNewConnection onDisconnect
            } 

        let handShake(server: LUServer) (ipep:IPEndPoint) (packet : LUPacket) =
            let response = BitStream()
            let clientVersion = packet.Body.ReadUInt32()
            response.WriteUInt64((uint64)packet.Header)
            response.WriteUInt32(clientVersion)
            response.WriteUInt32((uint32)0x93)
            response.WriteUInt32((uint32)4)
            using(Process.GetCurrentProcess()) (fun currentProcess -> 
                response.WriteUInt32((uint32)currentProcess.Id)
            )
            server.Server.Send(response,ipep) |> ignore

        let newConnection (server : LUServer) (ipep : IPEndPoint) = 
            Console.WriteLine("{0}:{1} connected to {2}",ipep.Address,ipep.Port,server.Name);

        let disconnection (server : LUServer) (ipep : IPEndPoint) =
            
            Console.WriteLine("{0}:{1} disconnected from {2}",ipep.Address,ipep.Port,server.Name)

        let handlePacket (server : LUServer)  (ipep : IPEndPoint) (data : byte[]) = 
            let luPacket = LUPacket(data)
            Console.WriteLine("Packet recieved: {0}",luPacket.Header)

            //server.HandlerMap.[luPacket.Header].DynamicInvoke(ipep,luPacket) |> ignore
        let unknownPacket (server : LUServer) (packet :LUPacket) =
            printfn "Unkown packet %X sent to server %s" (uint32 packet.Header) server.Name

        let sendGameMessage<'T> (server : LUServer)  (ipep : IPEndPoint) (messageInfo : GameMessage.GameMessageInfo) (messageSerializer) (message: 'T)=
            let response = BitStream()
            
            response.WriteUInt64(uint64 LUPacketHeader.ServerGameMessage)
            response.WriteInt64(messageInfo.objectId)
            response.WriteUInt16(uint16 messageInfo.messageId)
            messageSerializer(response, message)
            server.Server.Send(response,ipep)




    module AuthServer = 
        let handleAuthPacket (server : LUServer)  (ipep : IPEndPoint) (data : byte[]) =
            let packet = LUPacket data
            let header = packet.Header
            async{
                match header with
                    | LUPacketHeader.HandShake -> AuthServer.handShake server ipep packet
                    | LUPacketHeader.ClientLogin -> AuthServer.clientLogin server ipep packet
                    | _ -> LUServer.unknownPacket server packet
            } |> Async.Ignore|> Async.Start


        let clientLogin (authServer : LUServer) (ipep : IPEndPoint) (packet : LUPacket) =
            let users = LUDatabase.getContext().Users
            let username = packet.Body.ReadString(33,true)
            let pwd = packet.Body.ReadString(41,true)
            Console.WriteLine("Login with Username: {0} and Password {1}",username,pwd)
            let response = BitStream()
            response.WriteUInt64((uint64)LUPacketHeader.LoginResponse)
            let userExsists = query{
                for student in users do
                    select (student.Username, student.Password)
                    contains (username,pwd)
            }
            let loginResult = 
                match userExsists with 
                    |true -> LoginResponse.SUCCESS
                    |false -> LoginResponse.INVALID_LOGIN_INFO

            response.WriteByte((byte)loginResult)
            response.WriteString("Talk_Like_A_Pirate")
            response.WriteString("",33*7)
            response.WriteUShort((uint16)1)
            response.WriteUShort((uint16)10)
            response.WriteUShort((uint16)64)
            let userkey = String.Concat(Guid.NewGuid().ToString().ToCharArray(0,20))
            
            response.WriteString(userkey.ToString(),wide = true)
            response.WriteString("127.0.0.1")
            response.WriteString("127.0.0.1")
            response.WriteUShort((uint16)2002)
            response.WriteUShort((uint16)2200)
            response.WriteString("0.0.0.0")
            response.WriteString("00000000-0000-0000-0000-000000000000",37)
            response.WriteUInt((uint32)0)
            response.WriteString("US",3)
            response.WriteByte((byte)0)
            response.WriteByte((byte)0)
            response.WriteULong((uint64)0)
            let err = "Hello there ;D"
            response.WriteUInt16((uint16)err.Length)
            response.WriteString(err,err.Length,wide = true)
            response.WriteInt((int32)4)
            authServer.Server.Send(response,ipep)
            
            if(loginResult = LoginResponse.SUCCESS) then
                let userId = query{
                    for user in users do
                        where(user.Username = username && user.Password = pwd)
                        select user.Id
                        exactlyOne
                }
                let session = {UserKey = userkey; UserId = userId}
                ServiceProvider.GetService<ISessionService>().NewSession(ipep,session)
            Console.WriteLine("Auth finished")

        let handShake (authServer : LUServer) (ipep: IPEndPoint) (packet : LUPacket) =
            let response = BitStream()
            let client_version = packet.Body.ReadUInt32()
            
            response.WriteUInt64((uint64)packet.Header)
            response.WriteUInt32(client_version)
            response.WriteUInt32((uint32)0x93)
            response.WriteUInt32((uint32)1)
            using(Process.GetCurrentProcess()) (fun currentProcess -> 
                response.WriteUInt32((uint32)currentProcess.Id)
            )
            
            response.WriteString("127.0.0.1",33)
            authServer.Server.Send(response,ipep) |> ignore
            
            
    module WorldServer = 
        
        let startServer(server: WorldServer) (onReceive) (onNewConnection) (onDisconnect)  = 
            Console.WriteLine("Starting: {0}",server.Name)
            server.Server <- RakNetServer(server.Port,server.Password)
            server.Server.add_PacketReceived(fun (ipep) (data) -> onReceive server ipep data)
            server.Server.add_NewConnection(fun ipep -> onNewConnection server ipep)
            server.Server.add_Disconnection(fun ipep -> onDisconnect server ipep)
            server.Server.Start()
        let startServerAsync (server: WorldServer) (onReceive) (onNewConnection) (onDisconnect) =
            async{
                WorldServer.startServer server onReceive onNewConnection onDisconnect
                WorldServer.registerZones server
            } 
           
        let registerZones (worldServer : WorldServer) = 
            worldServer.Zones <- List.ofSeq (Zone.registerZones())
            

        let handleWorldPacket (server : WorldServer)  (ipep : IPEndPoint) (data : byte[]) = 
        
            let packet = LUPacket data
            let header = packet.Header
            async{
            match header with
                | LUPacketHeader.HandShake -> LUServer.handShake (server :> LUServer) ipep packet
                | LUPacketHeader.UserSessionInfo -> WorldServer.userSessionInfo server ipep packet
                | LUPacketHeader.MinifigListRequest -> WorldServer.minifigListRequest server ipep packet
                | LUPacketHeader.MinifigCreateRequest -> WorldServer.minifigCreateRequest server ipep packet
                | LUPacketHeader.UserJoinWorldRequest ->WorldServer.userJoinWorld server ipep packet
                | LUPacketHeader.ClientLoadComplete -> WorldServer.sendDetailedUserInfo server ipep packet
                | _ -> LUServer.unknownPacket server packet
            } |> Async.Ignore |> Async.Start
            



        let handleDisconnect server ipep =
            LUServer.disconnection server ipep
            let sessionService = ServiceProvider.GetService<ISessionService>()
            let sessionKey = sessionService.FindByIp ipep
            if sessionService.RemoveSession(ipep) then
                printfn "Session ended: %s" sessionKey.Value.UserKey

        let userSessionInfo (worldServer : WorldServer) ( ipep : IPEndPoint) (packet : LUPacket) =
            let username = packet.Body.ReadString(wide = true)
            let key = packet.Body.ReadString(wide = true)
            let hash = packet.Body.ReadString(32)
            
            let session = ServiceProvider.GetService<ISessionService>().FindByIp(ipep)
            match session with 
                | Some(session) -> Console.WriteLine("User logged in with session id: {0}", key)
                | None -> Console.WriteLine("Session not found: {0}",key)

        let minifigListRequest (worldServer : WorldServer) ( ipep : IPEndPoint) (packet : LUPacket) =
            let response = BitStream()
            
            let session = ServiceProvider.GetService<ISessionService>().FindByIp(ipep)
            use db = LUDatabase.getContext()
            let minifigs = 
                if session.IsSome then
                    db.Characters.Where(fun c -> c.UserId = session.Value.UserId).ToList() :> seq<Character>
                    
                else
                    Seq.empty
            
            response.WriteUInt64((uint64)LUPacketHeader.MinifigListResponse)
            response.WriteUInt8((byte)(Seq.length minifigs))
            
            response.WriteUInt8((byte)0)
            
            Seq.iter(fun minifig -> writeMinifig response minifig db ) minifigs
            worldServer.Server.Send(response)
            
            
            
        let writeMinifig (response :BitStream) (minifig: Character) (context : BaseContext) =
            
            response.WriteInt64(minifig.Id)
            response.WriteUInt32(uint32 0)
            response.WriteString(minifig.Name, wide = true)
            response.WriteString("", wide = true)
            response.WriteByte(byte 0)
            response.WriteByte(byte 0)
            response.WriteUInt32(minifig.HeadColor)
            response.WriteUInt16(uint16 0)
            response.WriteUInt32(minifig.Head)
            response.WriteUInt32(minifig.ShirtColor)
            response.WriteUInt32(minifig.ShirtStyle)
            response.WriteUInt32(minifig.PantsColor)
            response.WriteUInt32(minifig.HairStyle)
            response.WriteUInt32(minifig.HairColor)
            response.WriteUInt32(minifig.LH)
            response.WriteUInt32(minifig.RH)
            response.WriteUInt32(minifig.Eyebrows)
            response.WriteUInt32(minifig.Eyes)
            response.WriteUInt32(minifig.Mouth)
            response.WriteUInt32(uint32 0)
            response.WriteUInt16(uint16 minifig.Zone) //Zone
            response.WriteUInt16(minifig.LastMapInstance)
            response.WriteUInt32(minifig.LastMapClone)
            response.WriteUInt64(uint64 0) //Last time logn
            let minifigItems  = context.InventoryItems.Where(fun i -> i.CharacterId = minifig.Id) :> seq<InventoryItem>
            
            response.WriteUInt16(uint16 (Seq.length minifigItems))//Num items
            Seq.iter(fun (i : InventoryItem) -> response.WriteUInt32(uint32 i.Lot)) minifigItems
            

        let minifigCreateRequest (worldServer : WorldServer) ( ipep : IPEndPoint) (packet : LUPacket) =
            
            let session = ServiceProvider.GetService<ISessionService>().FindByIp ipep
            let newChar = new Character()
            let response = BitStream()
            let resources = ServiceProvider.GetService<IResourceService>()
            
            use db = LUDatabase.getContext()
            let user =  query{
                for user in db.Users do
                    where(user.Id = session.Value.UserId)
                    select user
                    exactlyOne
            }
            let namesAsync = 
                [resources.ReadTextAsync("names/minifigname_first.txt") ;
                resources.ReadTextAsync("names/minifigname_last.txt")  ;
                resources.ReadTextAsync("names/minifigname_last.txt") ] 
                |> Async.Parallel

            use cdContext = CDClientDatabase.getContext()
            
            
            newChar.Id <- Replica.objectId()
            newChar.Name <- packet.Body.ReadString(33,wide = true)
            let names = namesAsync |> Async.RunSynchronously

            let first = ((names.[0]).Split "\n").[int32 (packet.Body.ReadUInt32())]
            let middle = ((names.[1]).Split "\n").[int32 (packet.Body.ReadUInt32())]
            let last = ((names.[2]).Split "\n").[int32 (packet.Body.ReadUInt32())]
            
            newChar.DisplayName <- String.concat "" [first; middle; last;]
            
            packet.Body.ReadUInt8() |> ignore
            newChar.HeadColor <- packet.Body.ReadUInt32()
            newChar.Head <- packet.Body.ReadUInt32()

            newChar.ShirtColor <- packet.Body.ReadUInt32()
            newChar.ShirtStyle <- packet.Body.ReadUInt32()
            newChar.PantsColor <- packet.Body.ReadUInt32()
            newChar.HairStyle <- packet.Body.ReadUInt32()
            newChar.HairColor <- packet.Body.ReadUInt32()
            newChar.LH <- packet.Body.ReadUInt32()
            newChar.RH <- packet.Body.ReadUInt32()
            newChar.Eyebrows <- packet.Body.ReadUInt32()
            newChar.Eyes <- packet.Body.ReadUInt32()
            newChar.Mouth <- packet.Body.ReadUInt32()
           
            packet.Body.ReadUInt8() |> ignore
            newChar.Zone <- uint16 1000
            newChar.User <- user

            let brickColor = CDClientDatabase.getBrickColor cdContext newChar.ShirtColor
            let shirtName = sprintf "%s Shirt %d" brickColor.Description newChar.ShirtStyle
            let shirtLot = cdContext.Objects.ToArray().FirstOrDefault(fun o -> o.Name.ToLower() = shirtName.ToLower())
            
            let pantsColor = CDClientDatabase.getBrickColor cdContext newChar.PantsColor
            let pantsName = sprintf "%s Pants" pantsColor.Description
            let pantsLot = cdContext.Objects.ToArray().FirstOrDefault(fun o -> o.Name.ToLower() = pantsName.ToLower())

            
            let pantsItem = InventoryItem()
            pantsItem.Id <- Replica.objectId()
            pantsItem.Equipped <- true
            pantsItem.Lot <- if pantsLot <> null then uint32 pantsLot.Id.Value else uint32 4049

            let shirtItem = InventoryItem()
            shirtItem.Id <- Replica.objectId()
            shirtItem.Equipped <- true
            shirtItem.Lot <- if shirtLot <> null then uint32 shirtLot.Id.Value else uint32 2508
            newChar.Inventory.AddRange([|shirtItem; pantsItem|])

            let char =db.Characters.Add(newChar)
            
            let numRows = db.SaveChanges()
            response.WriteUInt64(uint64 LUPacketHeader.MinifigCreateResponse)
            response.WriteUInt8((byte)0)
            worldServer.Server.Send(response,ipep)
            minifigListRequest worldServer ipep packet
            
            

        let sendWorldInfo (worldServer : WorldServer) ( ipep : IPEndPoint) (minifigId) =
            let session = ServiceProvider.GetService<ISessionService>().FindByIp(ipep)
            
            use db = LUDatabase.getContext()
            let user =  db.Users.Where(fun u -> u.Id = session.Value.UserId).Single()
            let character = db.Characters.Where(fun c -> c.Id = minifigId).Single()
            user.CurrentCharId <- character.Id
            (*let zone = using(CDClientDatabase.getContext()) (fun cdContext ->
                cdContext.ZoneTable.ToArray().Where(fun z -> uint16 z.ZoneId.Value = character.Zone).Single()
            )*)
            
            let zone = worldServer.Zones.Where(fun z -> z.zoneId = character.Zone).Single()


            let luzFile = zone.luzFile
            let response = BitStream()
            response.WriteUInt64(uint64 LUPacketHeader.WorldInfo)
            response.WriteUInt16(uint16 zone.zoneId)
            printfn "Sending world info for zone: %d" zone.zoneId
            response.WriteUInt16(uint16 0)
            response.WriteUInt32(uint32 0)
            response.WriteUInt32(uint32 zone.checksum)
            response.WriteUInt16(uint16 0)
            response.WriteFloat(luzFile.SpawnPoint.X) //x
            response.WriteFloat(luzFile.SpawnPoint.Y) //y
            response.WriteFloat(luzFile.SpawnPoint.Z) //z
            response.WriteUInt32(uint32 0)
            db.SaveChanges() |> ignore
            worldServer.Server.Send(response, ipep)
            

        let userJoinWorld (worldServer : WorldServer) ( ipep : IPEndPoint) (packet : LUPacket) =
            let minifig = packet.Body.ReadLong()
            sendWorldInfo worldServer ipep minifig

        let sendDetailedUserInfo (worldServer : WorldServer) ( ipep : IPEndPoint) (packet : LUPacket)=
            let zoneId = packet.Body.ReadUInt16()
            let zone = worldServer.Zones.Where(fun z -> z.zoneId = zoneId).Single()
            let session = ServiceProvider.GetService<ISessionService>().FindByIp(ipep)
            let userId = session.Value.UserId
            let (charId,character) = using( LUDatabase.getContext()) (fun dbContext ->
                let charId = dbContext.Users.Where(fun u -> u.Id = userId).SingleOrDefault().CurrentCharId
                let character = dbContext.Characters.Where(fun c-> c.Id = charId).SingleOrDefault()
                (charId,character)
            )
            

            let ldf  =  [|{key="objid";dataType=LDFDataType.OBJID;value = int64 charId};
                        {key = "template";dataType = LDFDataType.S32;value=int32 1}|] 

            let serialzed =(LDF.serializeBinary (Seq.ofArray ldf))
            let compressed = serialzed |> LDF.compress
            let response = BitStream()
            let compressedSize = uint32(Array.length compressed)

            response.WriteUInt64(uint64 LUPacketHeader.DetailedUserInfo)
            response.WriteUInt32(compressedSize + uint32 9)
            response.WriteByte(byte 1)
            response.WriteUInt32(uint32 (Array.length serialzed))
            response.WriteUInt32(compressedSize)
            response.Write(compressed)

            printfn "Sending detailed user info"
            worldServer.Server.Send(response,ipep)
            let playerInfo : Object.ObjectInformation = {
                objectId = charId;
                Lot = 1;
                objectName = character.Name;
                timeSinceCreation = uint32 0;
                parent = None;
                children = List.empty;
                components = Set.empty
            }

            let player: GameObject.player = GameObject.player(character, playerInfo)
            let transform = transform(zone.luzFile.SpawnPoint,zone.luzFile.SpawnRotation,player)

            let components = Replica.getReplicaComponenents playerInfo.Lot player
            let components = Set.ofList ((transform :> Component.``component``)::components)
            CoreTypes.Component.addComponents (player) (components)
            Zone.addPlayerToZone zone player
            let construction = Replica.constructObject player
            
            worldServer.Server.Send(construction,ipep)

            LUServer.sendGameMessage worldServer ipep {messageId = GameMessage.ServerDoneLoadingObjects;objectId = charId} (fun (serializer, message) -> printfn "Server done loading objects") 0
            LUServer.sendGameMessage worldServer ipep {messageId = GameMessage.PlayerReader;objectId = charId} (fun (serializer, message) -> printfn "Player ready") 0
