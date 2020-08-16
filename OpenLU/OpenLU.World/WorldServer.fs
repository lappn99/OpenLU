namespace OpenLU.World

open RakDotNet
open OpenLU.Core
open RakDotNet.RakNet
open System.Net
open System
open OpenLU.Services

open OpenLU.Core
open System.Diagnostics

type WorldServer() as this = 
    inherit LUServer(2002,"3.25 ND1","World Server")
    interface IWorldServerService with
        member this.Start() = this.StartServer()

    override this.NewConnection ipep = 
        Console.WriteLine("{0}:{1} Connected to world service")
    override this.HandlePacket ipep data =
        
        let luPacket = LUPacket(data)
        Console.WriteLine("Header: {0}",luPacket.Header)
        this.HandlerMap.[luPacket.Header].DynamicInvoke(ipep,luPacket) |> ignore
        Console.WriteLine("received packet from {0}:{1} with id {2}",ipep.Address,ipep.Port,data.[0]);

    