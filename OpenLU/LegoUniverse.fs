﻿namespace OpenLU
open OpenLU.Services
open OpenLU.Services
open OpenLU.Models
open OpenLU.Servers
module LegoUniverse = 
    let Start() =
            let authServer = LUServer(1001,"3.25 ND1","Auth Server")
            let worldServer = LUServer(2002,"3.25 ND1","World Server")
            [|LUServer.startServerAsync authServer AuthServer.handleAuthPacket LUServer.newConnection LUServer.disconnection ;
            LUServer.startServerAsync worldServer WorldServer.handleWorldPacket LUServer.newConnection WorldServer.handleDisconnect|] |> Async.Parallel |> Async.RunSynchronously
            
            
        
        
        

