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
let main argv =
    Services.ServiceProvider.RegisterService<ISessionService>(SessionCache())
    
    LegoUniverse.Start()
    
    Console.ReadKey() |> ignore
    


    0