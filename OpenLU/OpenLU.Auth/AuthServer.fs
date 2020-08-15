

namespace OpenLU.Auth

open RakDotNet
open OpenLU.Core
open RakDotNet.RakNet
open System.Net
open System
open OpenLU.Services
type AuthServer() = 
    inherit LUServer(1001,"3.25 ND1")
    override this.HandlePacket ipep data =
        Console.WriteLine("received packet from {0}:{1} with id {2}",ipep.Address,ipep.Port,data.[0]);
    
    interface IAuthServerService with
        member this.Start() = this.StartServer()
