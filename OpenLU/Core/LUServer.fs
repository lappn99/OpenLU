namespace OpenLU.Core
open RakDotNet
open System.Net
open System.Threading.Tasks
open RakDotNet.TcpUdp
open System
open RakDotNet.RakNet
open System.Collections.Generic
open System.Diagnostics
open OpenLU.Core.Enums
[<AbstractClass>]
type LUServer(port : int, password : string,name : string) as this =

    let  _port = port
    let  _password = password
    let _handlerMap :Dictionary<LUPacketHeader,Delegate> = Dictionary<LUPacketHeader,Delegate>()
    let _name = name
    let mutable  _server : IRakNetServer = null

    do
        _handlerMap.Add(LUPacketHeader.HandShake,new HandshakeEvent(this.Handshake))

    member this.HandlerMap with get() = _handlerMap
    member this.Port with get() = _port
    member this.Password with get() = _password
    member this.Server with get() = _server and set(v : IRakNetServer) = _server <- v
    member this.Name with get() = _name

    abstract member StartServer : unit -> unit
    abstract member NewConnection : IPEndPoint -> unit
    abstract member HandlePacket : IPEndPoint -> byte[] ->unit
    abstract member Disconnection : IPEndPoint -> unit
    abstract member Handshake :IPEndPoint -> LUPacket -> unit

    member this.OnNewConnection : NewConnectionEvent = NewConnectionEvent(this.NewConnection)
    member this.OnHandlePacket : HandlePacketEvent = HandlePacketEvent(this.HandlePacket)
    member this.OnDisconnect : DisconnectionEvent = DisconnectionEvent(this.Disconnection)

    default this.NewConnection ipep =
        Console.WriteLine("{0}:{1} connected to {2}",ipep.Address,ipep.Port,this.Name);
    default this.Disconnection ipep =
        Console.WriteLine("{0}:{1} disconnected from {2}",ipep.Address,ipep.Port,this.Name)

    default this.StartServer() =
        Console.WriteLine("Starting {0}",this.Name)
        this.Server <- RakNetServer(this.Port,this.Password) :> IRakNetServer
        this.Server.add_PacketReceived(fun (ipep) (data) -> this.OnHandlePacket.Invoke(ipep,data))
        this.Server.add_NewConnection(fun ipep -> this.OnNewConnection.Invoke ipep)
        this.Server.add_Disconnection(fun ipep -> this.OnDisconnect.Invoke ipep)
        this.Server.Start()
    
    
    default this.Handshake (ipep : IPEndPoint) (packet : LUPacket) = 
        
        let response = BitStream()
        let client_version = packet.Body.ReadUInt32()
        response.WriteUInt64((uint64)packet.Header)
        response.WriteUInt32(client_version)
        response.WriteUInt32((uint32)0x93)
        response.WriteUInt32((uint32)4)
        let currentProcess = Process.GetCurrentProcess()
        response.WriteUInt32((uint32)currentProcess.Id)
        response.WriteString("127.0.0.1",33)
        this.Server.Send(response,ipep) |> ignore

    default this.HandlePacket ipep data =
        let luPacket = LUPacket(data)
        Console.WriteLine(BitConverter.ToInt32( data.[..8],0))
        Console.WriteLine("Receivid user packet: {0}", luPacket.Header)
        this.HandlerMap.[luPacket.Header].DynamicInvoke(ipep,luPacket) |> ignore


    
        


    
   

        


