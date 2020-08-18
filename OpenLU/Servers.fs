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
module rec Servers = 
    [<AbstractClass>]
    type LUServer(port : int, password : string,name : string) as this =
        
            let _handlerMap :Dictionary<LUPacketHeader,Delegate> = Dictionary<LUPacketHeader,Delegate>()
            
            let mutable  _server : IRakNetServer = null
            do
                _handlerMap.Add(LUPacketHeader.HandShake,new HandshakeEvent(this.Handshake))
        
            member  this.HandlerMap with get() = _handlerMap
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
            Console.WriteLine("{0}:{1} connected",ipep.Address,ipep.Port);

        let disconnection server (ipep : IPEndPoint) =
            Console.WriteLine("{0}:{1} disconnecteed",ipep.Address,ipep.Port)

        let handlePacket server (ipep : IPEndPoint) (data : byte[]) = 
            let luPacket = LUPacket(data)
            
            Console.WriteLine("Receivid user packet: {0}", luPacket.Header)
            server.HandlerMap.[luPacket.Header].DynamicInvoke(ipep,luPacket) |> ignore

    type AuthServer() as this = class
        inherit LUServer(1001,"3.25 ND1","Auth Server")
        do
            this.HandlerMap.Add(LUPacketHeader.ClientLogin ,new LoginEvent(this.ClientLogin))

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

            let loginResult = if userExsists then LoginResponse.SUCCESS else LoginResponse.INVALID_LOGIN_INFO

            response.WriteByte((byte)loginResult)
            response.WriteString("Talk_Like_A_Pirate")
            response.WriteString("",33*7)
            response.WriteUShort((uint16)1)
            response.WriteUShort((uint16)10)
            response.WriteUShort((uint16)64)
            let userkey = String.Concat(Guid.NewGuid().ToString().ToCharArray(0,20))
            Console.WriteLine("New user of : {0}",userkey)
            response.WriteString(userkey,wide = true)
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
        interface IWorldServerService with
            member this.Start() = this.StartServer()
    end
