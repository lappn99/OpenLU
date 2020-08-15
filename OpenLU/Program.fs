// Learn more about F# at http://fsharp.org

open System
open OpenLU.Core
open OpenLU.Auth
[<EntryPoint>]
let main argv =
    let lu = LegoUniverse(AuthServer())
    lu.Start()
    Console.ReadKey() |> ignore
    0