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
            mutable players: list<GameObject.Player>
            checksum: uint32
            luzFile: LuzFile 
        }

    let addPlayerToZone (zone: zone) (player: GameObject.Player) = 
        let playerComponents = getObjectComponenents player.objectInfo.Lot player.objectInfo
        GameObject.addComponents player.objectInfo playerComponents
        zone.players <- player::zone.players



    let registerZones() =
        let zones = seq {
            let zonesFile = File.ReadAllLines("zones.txt")
            use cdContext = CDClientDatabase.getContext ()
            for line in zonesFile do
                let (zoneId, checksum) = (line.Split(":").[0] |> uint16, line.Split(":").[1] |> uint32)

                let zoneName = cdContext.ZoneTable.ToArray().Where(fun z -> z.ZoneId.Value = int64 zoneId).Single().ZoneName

                let luzFile = LUResources.getZone (zoneName)

                yield{ zoneId = zoneId;players = List.empty;checksum = checksum;luzFile = luzFile }
        }
        Seq.iter (fun z -> (printfn "zone %d registered" z.zoneId)) zones
        zones

