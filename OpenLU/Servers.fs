namespace OpenLU

open System.Collections.Generic
open CoreTypes
open RakDotNet
open System
open System.Net
open CoreTypes.Events
open Services
open RakDotNet.RakNet
open System.Diagnostics
open OpenLU.Services
open System.Linq
open OpenLU.CoreTypes.Enums
open Microsoft.FSharp.Collections
open OpenLU.Models.GameModels
open Replica
module rec Servers = 
    [<AbstractClass>]
    type LUServer(port : int, password : string,name : string) as this =
        
            let mutable _handlerMap : Map<LUPacketHeader,Delegate> = Map.empty
            
            let mutable  _server : IRakNetServer = null
            do
                _handlerMap <- _handlerMap.Add(LUPacketHeader.HandShake,new ClientPacketEvent(this.Handshake))
        
            member  this.HandlerMap with get() = _handlerMap and set(v : Map<LUPacketHeader,Delegate>) = _handlerMap <- v 
            member this.Port with get() = port
            member this.Password with get() = password
            member this.Server with get() = _server and set(v : IRakNetServer) = _server <- v
            member this.Name with get() = name
        
            abstract member  StartServer : unit -> unit
            abstract member NewConnection : IPEndPoint -> unit
            abstract member HandlePacket : IPEndPoint -> byte[] ->unit
            abstract member Disconnection : IPEndPoint -> unit
            abstract member Handshake :IPEndPoint -> LUPacket -> unit
        
            member this.OnNewConnection : NewConnectionEvent = NewConnectionEvent(this.NewConnection)
            member this.OnHandlePacket : HandlePacketEvent = HandlePacketEvent(this.HandlePacket)
            member this.OnDisconnect : DisconnectionEvent = DisconnectionEvent(this.Disconnection)

            default this.StartServer() = LUServer.startServer this
            default this.Handshake (ipep : IPEndPoint) (packet : LUPacket) = LUServer.handShake this ipep packet
            default this.NewConnection(ipep) = LUServer.newConnection this ipep
            default this.Disconnection(ipep) = LUServer.disconnection this ipep
            default this.HandlePacket ipep data = LUServer.handlePacket this ipep data

    module LUServer =
        let startServer(server: LUServer) = 
            Console.WriteLine("Starting: {0}",server.Name)
            server.Server <- RakNetServer(server.Port,server.Password)
            server.Server.add_PacketReceived(fun (ipep) (data) -> server.OnHandlePacket.Invoke(ipep,data))
            server.Server.add_NewConnection(fun ipep -> server.OnNewConnection.Invoke ipep)
            server.Server.add_Disconnection(fun ipep -> server.OnDisconnect.Invoke ipep)
            server.Server.Start()

        let handShake(server: LUServer) (ipep:IPEndPoint) (packet : LUPacket) =
            let response = BitStream()
            let clientVersion = packet.Body.ReadUInt32()
            response.WriteUInt64((uint64)packet.Header)
            response.WriteUInt32(clientVersion)
            response.WriteUInt32((uint32)0x93)
            response.WriteUInt32((uint32)4)
            let currentProcess = Process.GetCurrentProcess()
            response.WriteUInt32((uint32)currentProcess.Id)
            response.WriteString("127.0.0.1",33)
            
            server.Server.Send(response,ipep) |> ignore

        let newConnection server (ipep : IPEndPoint) = 
            Console.WriteLine("{0}:{1} connected to {2}",ipep.Address,ipep.Port,server.Name);

        let disconnection server (ipep : IPEndPoint) =
            
            Console.WriteLine("{0}:{1} disconnected from {2}",ipep.Address,ipep.Port,server.Name)

        let handlePacket server (ipep : IPEndPoint) (data : byte[]) = 
            let luPacket = LUPacket(data)
            Console.WriteLine("Packet recieved: {0}",luPacket.Header)

            server.HandlerMap.[luPacket.Header].DynamicInvoke(ipep,luPacket) |> ignore

    type AuthServer() as this = class
        inherit LUServer(1001,"3.25 ND1","Auth Server")
        do
            this.HandlerMap <- this.HandlerMap.Add(LUPacketHeader.ClientLogin ,new ClientPacketEvent(this.ClientLogin))

        member this.ClientLogin (ipep : IPEndPoint) (packet : LUPacket) = AuthServer.clientLogin this ipep packet

        override this.Handshake (ipep: IPEndPoint) (packet : LUPacket) = AuthServer.handShake this ipep packet

        interface IAuthServerService with
            member this.Start() = this.StartServer()
    end
    module AuthServer = 
        let clientLogin (authServer : AuthServer) (ipep : IPEndPoint) (packet : LUPacket) =
            let users = ServiceProvider.GetService<IDatabasebaseService>().GetContext().Users
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

        let handShake (authServer : AuthServer) (ipep: IPEndPoint) (packet : LUPacket) =
            let response = BitStream()
            let client_version = packet.Body.ReadUInt32()
            
            response.WriteUInt64((uint64)packet.Header)
            response.WriteUInt32(client_version)
            response.WriteUInt32((uint32)0x93)
            response.WriteUInt32((uint32)1)
            let currentProcess = Process.GetCurrentProcess()
            response.WriteUInt32((uint32)currentProcess.Id)
            response.WriteString("127.0.0.1",33)
            authServer.Server.Send(response,ipep) |> ignore


    type WorldServer() as this = class
        inherit LUServer(2002,"3.25 ND1","World Server")
        do
            this.HandlerMap <- this.HandlerMap.Add(LUPacketHeader.UserSessionInfo,new ClientPacketEvent(this.UserSessionInfo))
            this.HandlerMap <- this.HandlerMap.Add(LUPacketHeader.MinifigListRequest,new ClientPacketEvent(this.MinifigListRequest))
            this.HandlerMap <- this.HandlerMap.Add(LUPacketHeader.MinifigCreateRequest,new ClientPacketEvent(this.MinifigCreateRequest))
        member this.UserSessionInfo (ipep) (packet) = WorldServer.userSessionInfo this ipep packet
        member this.MinifigListRequest (ipep) (packet) = WorldServer.minifigListRequest this ipep packet
        member this.MinifigCreateRequest  (ipep) (packet) = WorldServer.minifigCreateRequest this ipep packet
        override this.Disconnection  (ipep) = WorldServer.handleDisconnect this ipep
        interface IWorldServerService with
            member this.Start() = this.StartServer()
    end

    module WorldServer = 
        
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
            response.WriteUInt64((uint64)LUPacketHeader.MinifigListResponse)
            let session = ServiceProvider.GetService<ISessionService>().FindByIp(ipep)
            let minifigs = 
                if session.IsSome then
                    let db = ServiceProvider.GetService<IDatabasebaseService>().GetContext()
                    db.Characters.Where(fun c -> c.UserId = session.Value.UserId).ToList() :> seq<Character>
                else
                    Seq.empty
            
            
            response.WriteUInt8((byte)(Seq.length minifigs))
            response.WriteUInt8((byte)0)

            Seq.iter(fun minifig -> writeMinifig response minifig) minifigs
            worldServer.Server.Send(response)
        let writeMinifig (response :BitStream) (minifig: Character) =
            response.WriteInt64(minifig.Id)
            response.WriteUInt32(uint32 0)
            response.WriteString(minifig.Name, wide = true)
            response.WriteString(minifig.DisplayName,wide = true)
            response.WriteBool(false)
            response.WriteBool(false)
            response.WriteString("",10)
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
            response.WriteUInt16(minifig.LastMapInstance)
            response.WriteUInt32(minifig.LastMapClone)
            response.WriteUInt64(minifig.LastLogin)
            response.WriteUInt16(uint16 0)

        let minifigCreateRequest (worldServer : WorldServer) ( ipep : IPEndPoint) (packet : LUPacket) =
            let db = ServiceProvider.GetService<IDatabasebaseService>().GetContext()
            let session = ServiceProvider.GetService<ISessionService>().FindByIp ipep
            let newChar = new Character()
            let response = BitStream()
            let resources = ServiceProvider.GetService<IResourceService>()
       
            let user=  query{
                for user in db.Users do
                    where(user.Id = session.Value.UserId)
                    select user
                    exactlyOne
            }
            
            
            let firstNames = resources.ReadTextAsync("names/minifigname_first.txt") |> Async.RunSynchronously
            let middleNames = resources.ReadTextAsync("names/minifigname_last.txt") |> Async.RunSynchronously
            let lastNames = resources.ReadTextAsync("names/minifigname_last.txt") |> Async.RunSynchronously
            
            newChar.Id <- Replica.objectId
            newChar.Name <- packet.Body.ReadString(33,wide = true)
            let first = (firstNames.Split "\n").[int32 (packet.Body.ReadUInt32())]
            let middle = (middleNames.Split "\n").[int32 (packet.Body.ReadUInt32())]
            let last = (lastNames.Split "\n").[int32 (packet.Body.ReadUInt32())]
            
            newChar.DisplayName <- String.concat "" [first; middle; last;]
            
            packet.Body.ReadString(9,false) |> ignore
            
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
            (*newChar.LastMapInstance <- packet.Body.ReadUInt16()
            newChar.LastMapClone <- packet.Body.ReadUInt32()
            newChar.LastLogin <- packet.Body.ReadUInt64()*)
            newChar.User <- user
            
            let char =db.Characters.Add(newChar) 
            let numRows = db.SaveChanges()
            printfn "Character added: %s" char.Entity.DisplayName

            response.WriteUInt8((byte)0)
            worldServer.Server.Send(response,ipep)
            minifigListRequest worldServer ipep packet
            


