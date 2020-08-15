namespace OpenLU.Core
open RakDotNet
open System.Net
open System.Threading.Tasks
open RakDotNet.TcpUdp
open System
open RakDotNet.RakNet

[<AbstractClass>]

type LUServer(port : int, password : string) as this =

    let  _port = port
    let  _password = password
    let mutable  _server : IRakNetServer = null
    
    member this.Port with get() = _port
    member this.Password with get() = _password
    member this.Server with get() = _server and set(v : IRakNetServer) = _server <- v
    
    abstract member StartServer : unit -> unit
    abstract member NewConnection : IPEndPoint -> unit
    abstract member HandlePacket : IPEndPoint -> byte[] ->unit
    abstract member Disconnection : IPEndPoint -> unit

    default this.NewConnection ipep =
        Console.WriteLine("{0}:{1} connected",ipep.Address,ipep.Port);
    default this.Disconnection ipep =
        Console.WriteLine("{0}:{1} disconnecteed",ipep.Address,ipep.Port)

    member this.OnNewConnection : NewConnectionEvent = NewConnectionEvent(this.NewConnection)
    member this.OnHandlePacket : HandlePacketEvent = HandlePacketEvent(this.HandlePacket)
    member this.OnDisconnect : DisconnectionEvent = DisconnectionEvent(this.Disconnection)

    default this.StartServer() =
        Console.WriteLine("Starting server")
        this.Server <- RakNetServer(this.Port,this.Password) :> IRakNetServer
        (*this.Server.add_NewConnection(Action<IPEndPoint>(this.OnNewConnection))
        this.Server.add_PacketReceived(Action<IPEndPoint,byte[]>(this.HandlePacket))*)
        this.Server.add_PacketReceived(fun (ipep) (data) -> this.OnHandlePacket.Invoke(ipep,data))
        this.Server.add_NewConnection(fun ipep -> this.OnNewConnection.Invoke ipep)
        this.Server.add_Disconnection(fun ipep -> this.OnDisconnect.Invoke ipep)
        this.Server.Start()
    
    



    
        


    
   

        


