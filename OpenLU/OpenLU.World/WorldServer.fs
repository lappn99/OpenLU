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


    