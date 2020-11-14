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
open OpenLU.CoreTypes.Object
open OpenLU.CoreTypes
open System.Linq
open System.Reflection
open OpenLU.GameComponent
open OpenLU.CoreTypes
open OpenLU.Attributes
module rec Replica = 
    let random = new Random()
    let objectId()  = random.LongRandom(100000000000000000L, 999999999999999999L)

    let getReplicaComponenents lot (parent : Object.object) =
        use cdContext = CDClientDatabase.getContext()
        let requiredComponents = cdContext.ComponentsRegistry.ToArray().Where(fun c-> int c.Id.Value = lot).Select(fun c -> int c.ComponentType.Value).ToArray()
        let assembly = Assembly.GetExecutingAssembly()
        let componentTypes = assembly.GetTypes().Where(fun t-> t.Namespace = "OpenLU" && Attribute.GetCustomAttribute(t,typeof<ComponentTypeAttribute>) <> null).ToArray()

        seq{
            for componentType in componentTypes do
                let attr = Attribute.GetCustomAttribute(componentType,typeof<ComponentTypeAttribute>) 
                let componentAttribute : ComponentTypeAttribute = downcast attr
                if requiredComponents.Contains(componentAttribute.ComponentType) then
                    
                    match componentType with
                        | _ when componentType = typeof<ReplicaComponent.characterComponent> -> 
                            yield ReplicaComponent.characterComponent(parent :?> GameObject.player) :> Component.``component``
                        | _ -> ()

                   
            } |> List.ofSeq
                
                
     
    let constructObject<'T> (object : Object.object) = 
        let bitStream = BitStream()
        let objectInfo = object.ObjectInfo

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
            List.iter (fun (c : ObjectInformation) -> bitStream.WriteInt64(c.objectId)) objectInfo.children
        else
            bitStream.WriteBit(false)

        for comp in objectInfo.components do
            match comp with
                | :? ReplicaComponent.replicaComponent as replicaComponent -> replicaComponent.Construct(bitStream)
                | _ -> ()


        bitStream.BaseBuffer

        


    

        







        

