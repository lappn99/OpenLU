namespace OpenLU

open OpenLU.CoreTypes
open OpenLU.Replica
open InfectedRose.Lvl
open InfectedRose.Luz
open RakDotNet
open System.IO
open OpenLU.LUResources
open System.Linq

module Zone =


    type zone =
        {

          zoneId: uint16
          mutable players: list<GameObject.Player>
          checksum: uint32
          luzFile: LuzFile }

    let addPlayerToZone (zone: zone) (player: GameObject.Player) = zone.players <- player :: zone.players



    let registerZones () =
        let zones =
            seq {
                let zonesFile = File.ReadAllLines("zones.txt")
                use cdContext = CDClientDatabase.getContext ()

                for line in zonesFile do
                    let (zoneId, checksum) =
                        (line.Split(":").[0] |> uint16, line.Split(":").[1] |> uint32)

                    let zoneName =
                        cdContext
                            .ZoneTable
                            .ToArray()
                            .Where(fun z -> z.ZoneId.Value = int64 zoneId)
                            .Single()
                            .ZoneName

                    let luzFile = LUResources.getZone (zoneName)

                    yield
                        { zoneId = zoneId
                          players = List.empty
                          checksum = checksum
                          luzFile = luzFile }
            }

        Seq.iter (fun z -> (printfn "zone %d registered" z.zoneId)) zones
        zones
