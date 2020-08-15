namespace LegoUniverse.Networking
open System
open System.IO
open System.Net
open System.Net.Sockets
open System.Threading
type Server(port: int) =
    let endPoint = IPEndPoint(IPAddress.Loopback,port)
    let listener = new UdpClient(endPoint)
    let sender = IPEndPoint(IPAddress.Loopback,0)
    member this.StartServer() = 
        Console.WriteLine("Starting server")
        listener.BeginReceive(new AsyncCallback(this.RecievePacket),listener) |> ignore
    member this.RecievePacket(result: IAsyncResult) =
        let data : byte[] = listener.EndReceive(result,ref sender)
        this.HandlePacket(data)
        listener.BeginReceive(new AsyncCallback(this.RecievePacket),listener) |> ignore
    abstract member HandlePacket : byte[] -> unit
    default this.HandlePacket(data : byte[]) = 
        Console.WriteLine("Received {0} bytes from {1}",data.Length,sender.ToString())




