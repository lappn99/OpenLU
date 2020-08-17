// Learn more about F# at http://fsharp.org

open System
open OpenLU
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
open OpenLU.LegoUniverse
open OpenLU.Servers
[<EntryPoint>]
let main argv =
    
    let authServer = AuthServer()
    let worldServer = WorldServer()
    
    let lu = LegoUniverse(authServer,worldServer)
    lu.Start()
    
    (*serviceCollection.AddSingleton<LegoUniverse>() |> ignore
    serviceCollection.AddSingleton<IAuthServerService,AuthServer>() |> ignore
    serviceCollection.AddSingleton<IWorldServerService,WorldServer>() |> ignore
    let serviceProvider = serviceCollection.BuildServiceProvider(true)
    let scope = serviceProvider.CreateScope()
    scope.ServiceProvider.GetRequiredService<LegoUniverse>().Start()*)
    Console.ReadKey() |> ignore
    0