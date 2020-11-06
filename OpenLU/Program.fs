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
[<EntryPoint>]
let main argv =
    
    
    Services.ServiceProvider.RegisterService<ISessionService>(SessionCache())
    Services.ServiceProvider.RegisterService<IResourceService>(LocalResourceProvider())
    LegoUniverse.Start()
    
    Console.ReadKey() |> ignore
    0