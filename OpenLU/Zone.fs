namespace OpenLU
open OpenLU.CoreTypes
open InfectedRose.Luz
open System.IO
open System.Linq
open OpenLU.Replica
open OpenLU.CoreTypes
module Zone =
    type zone =
        {
            zoneId: uint16
            mutable players: list<GameObject.player>
            checksum: uint32
            luzFile: LuzFile 
        }

    let addPlayerToZone (zone: zone) (player: GameObject.player) = 
        zone.players <- player::zone.players



    let registerZones() =
        seq {
            printfn "Registering zones"
            let zonesFile = File.ReadAllLines("zones.txt")
            use cdContext = CDClientDatabase.getContext ()
            let zoneTable = cdContext.ZoneTable.ToList()
            for line in zonesFile do
                let (zoneId, checksum) =  line.Split(":") |> (fun arr -> (arr.[0] |> uint16,arr.[1] |> uint32))

                let zoneName = zoneTable.Where(fun z -> z.ZoneId.Value = int64 zoneId).Single().ZoneName

                let luzFile = LUResources.getZone (zoneName)
                printfn "zone %s registered" zoneName
                yield{ zoneId = zoneId;players = List.empty;checksum = checksum;luzFile = luzFile }
        }
        
        

