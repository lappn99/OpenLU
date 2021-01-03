namespace OpenLU
open OpenLU.Services
open OpenLU.Services
open OpenLU.Models
open OpenLU.Servers
open OpenLU.Zone
open System

module LegoUniverse = 
    let Start serverType port =
          let serverStart = 
            match serverType with
                | "-world" -> 
                    let worldServer = WorldServer(port,"3.25 ND1","World Server" )
                    Console.Title <- sprintf "World Server: %d" port
                    [|WorldServer.startServerAsync worldServer WorldServer.handleWorldPacket LUServer.newConnection WorldServer.handleDisconnect;WorldServer.registerZonesAsync worldServer|]
                | "-auth" -> 
                    let authServer = LUServer(port,"3.25 ND1","Auth Server")
                    Console.Title <- sprintf "Auth Server: %d" port
                    [|LUServer.startServerAsync authServer AuthServer.handleAuthPacket LUServer.newConnection LUServer.disconnection|]
                | "-all" -> 
                    let worldServer = WorldServer(2002,"3.25 ND1","World Server" )
                    let authServer = LUServer(1001,"3.25 ND1","Auth Server")
                    Console.Title <- "OpenLU"
                    [|WorldServer.startServerAsync worldServer WorldServer.handleWorldPacket LUServer.newConnection WorldServer.handleDisconnect;
                    LUServer.startServerAsync authServer AuthServer.handleAuthPacket LUServer.newConnection LUServer.disconnection;
                    WorldServer.registerZonesAsync worldServer|]
          serverStart |> Async.Parallel |> Async.RunSynchronously

            
            
        
        
        

