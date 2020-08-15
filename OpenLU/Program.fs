// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Net
open System.Net.Sockets
open System.Threading
open LegoUniverse.Networking
[<EntryPoint>]
let main argv =
   let server = Server(1001)
   server.StartServer()
   Console.ReadKey() |> ignore
   0