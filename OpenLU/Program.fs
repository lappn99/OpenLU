// Learn more about F# at http://fsharp.org

open System
open OpenLU
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
open OpenLU.LegoUniverse
open OpenLU.Servers
open OpenLU.Services.ServiceProvider
open OpenLU.Services

[<EntryPoint>]
let main argv =
    
    Services.ServiceProvider.RegisterService<IAuthServerService>(AuthServer())
    Services.ServiceProvider.RegisterService<IWorldServerService>(WorldServer())
    Services.ServiceProvider.RegisterService<IDatabasebaseService>(LUDatabase())
    Services.ServiceProvider.RegisterService<ISessionService>(SessionCache())
    LegoUniverse.Start()
    
    Console.ReadKey() |> ignore
    0