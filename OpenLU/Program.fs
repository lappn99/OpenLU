// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Net
open System.Net.Sockets
open System.Threading
open OpenLU.Core
open OpenLU.Auth
open OpenLU.Services
[<EntryPoint>]
let main argv =
    let lu = LegoUniverse(AuthServer())
    lu.Start()
    Console.ReadKey() |> ignore
    0