namespace OpenLU
open OpenLU.CoreTypes
open System.Numerics
open RakDotNet
open System.Reflection
module GameComponents =
    

    type Transform(pos, rot, parent)=
        inherit Component(parent,"Transform")
        let _position : Vector3 = pos
        let _rotation : Quaternion = rot
        let _velocity : Vector3 = Vector3.Zero
        let _grounded = false
        let _angularVelocity = Vector3.Zero
        member this.Position with get() = _position
        member this.Roation with get() = _rotation
        member this.Velocity with get() = _velocity
        member this.AngularVelocity with get() = _angularVelocity

    module ReplicaComponents =
        
        type ReplicaComponent(parent,name) =
            inherit Component(parent,name)
            abstract member Construct : BitStream -> unit
            default this.Construct(bitStream) = printfn "Constructing %s" name

        type ComponentTypeAttribute(componentType : int) = 
            inherit System.Attribute()
            member this.ComponentType with get() = componentType

        //TODO implement components
        [<ComponentType(4)>]
        type CharacterComponent(parent) =
            inherit ReplicaComponent(parent,"Character")
            let id =0
        


