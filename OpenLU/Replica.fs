namespace OpenLU

open System
open OpenLU.Extensions.RandomExtensions
open RakDotNet.RakNet
open RakDotNet
open System.Net
open InfectedRose.Luz
open System.IO
open OpenLU.CoreTypes.Enums
open System.Numerics
module rec Replica = 
    let random = new Random()
    let objectId()  = random.LongRandom(100000000000000000L, 999999999999999999L)

    

    let constructObject<'T> (objectInfo : GameObject.GameObjectInformation) = 
        let bitStream = BitStream()
        
        bitStream.WriteByte(byte ReplicaPacket.ReplicaConstruction)
        bitStream.WriteBit(true)
        bitStream.WriteUInt16(uint16 1)
        bitStream.WriteInt64(objectInfo.objectId)
        bitStream.WriteInt32(objectInfo.Lot)
        bitStream.WriteUInt8(uint8 objectInfo.objectName.Length)
        bitStream.WriteString(objectInfo.objectName,objectInfo.objectName.Length,true)
        bitStream.WriteUInt32(uint32 0)
        
        bitStream.WriteBit(false) //Has LDF struct
        bitStream.WriteBit(false) //Has trigger
        bitStream.WriteBit(false) //Has object id of spawner
        bitStream.WriteBit(false) //Has spawner node id
        bitStream.WriteBit(false) //Has scale
        bitStream.WriteBit(true)  //World scale
        bitStream.WriteFloat(1.0f)
        bitStream.WriteBit(false) //World state
        bitStream.WriteBit(false) //Has gm level
        bitStream.WriteBit(true)  //Hierarchy


        match objectInfo.parent with
            | Some(x) -> bitStream.WriteBit(true)
                         bitStream.WriteInt64(x.objectId)
                         bitStream.WriteBit(false)
            | None -> bitStream.WriteBit(false)
        
        if objectInfo.children.Length > 0 then
            bitStream.WriteBit(true)
            bitStream.WriteUInt16(uint16 objectInfo.children.Length)
            List.iter (fun (c : GameObject.GameObjectInformation) -> bitStream.WriteInt64(c.objectId)) objectInfo.children
        else
            bitStream.WriteBit(false)



        bitStream.BaseBuffer
        


    module GameObject =
        type GameObjectInformation = {
            objectId : int64;
            Lot : int32;
            objectName : string;
            timeSinceCreation : uint32;
            parent : Option<GameObjectInformation>;
            children : List<GameObjectInformation>
        }

        type Player ={
            objectInfo : GameObjectInformation
            
        }

        







        

