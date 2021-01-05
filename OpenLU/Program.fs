// Learn more about F# at http://fsharp.org

open System
open OpenLU
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
open OpenLU.LegoUniverse
open OpenLU.Servers
open OpenLU.Services.ServiceProvider
open OpenLU.Services
open OpenLU.LUResources
open OpenLU.Replica
[<EntryPoint>]
let main args =
    
    
    let port = if args.Length > 1 then args.[1] |> int else Int32.MinValue

    let result = LegoUniverse.Start args.[0] port
    
    Console.ReadKey() |> ignore
    0