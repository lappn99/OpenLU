namespace OpenLU
open OpenLU.Services
open OpenLU.Services
open OpenLU.Models
open OpenLU.Servers
open OpenLU.Zone
module LegoUniverse = 
    let Start() =
            let authServer = LUServer(1001,"3.25 ND1","Auth Server")
            let worldServer = WorldServer(2002,"3.25 ND1","World Server", List.ofSeq (Zone.registerZones()) )
            [|LUServer.startServerAsync authServer AuthServer.handleAuthPacket LUServer.newConnection LUServer.disconnection ;
            WorldServer.startServerAsync worldServer WorldServer.handleWorldPacket LUServer.newConnection WorldServer.handleDisconnect|] 
                |> Async.Parallel 
                |> Async.RunSynchronously
            
            
        
        
        

