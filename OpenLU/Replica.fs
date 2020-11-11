namespace OpenLU

open System
open OpenLU.Extensions.RandomExtensions
open RakDotNet.RakNet
open RakDotNet
open System.Net
open InfectedRose.Luz
open System.IO
open OpenLU.CoreTypes.Enums
module rec Replica = 
    let random = new Random()
    let objectId()  = random.LongRandom(100000000000000000L, 999999999999999999L)

    module Zone =
        type Zone ={
            zoneId : int32;
            mutable players : list<GameObject.Player>
            checksum : uint32
            luzFile : LuzFile
        }

        
        let addPlayerToZone (zone : Zone) (player : GameObject.Player) =
            zone.players <- player::zone.players

    let constructObject (objectInfo : GameObject.GameObjectInformation) = 
        let bitStream = BitStream()
        
        bitStream.WriteByte(byte ReplicaPacket.ReplicaConstruction)
        bitStream.WriteBit(true)
        bitStream.WriteUInt16(uint16 1)

        bitStream.WriteInt64(objectInfo.objectId)
        bitStream.WriteInt32(objectInfo.Lot)
        bitStream.WriteUInt8(uint8 objectInfo.objectName.Length)
        bitStream.WriteString(objectInfo.objectName,objectInfo.objectName.Length,true)
        bitStream.WriteUInt32(uint32 0)
        bitStream.WriteBit(false)
        bitStream.WriteUInt32(uint32 0)
        bitStream.BaseBuffer
        


    module GameObject =
        type GameObjectInformation = {
            objectId : int64;
            Lot : int32;
            objectName : string;
            timeSinceCreation : uint32;
            
        }

        type Player ={
            objectInfo : GameObjectInformation
        
        }

        







        

