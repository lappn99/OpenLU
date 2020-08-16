// Learn more about F# at http://fsharp.org

open System
open OpenLU.Core
open OpenLU.Auth
open OpenLU.World
[<EntryPoint>]
let main argv =
    let lu = LegoUniverse(AuthServer(),WorldServer())
    lu.Start()
    Console.ReadKey() |> ignore
    0