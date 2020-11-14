namespace OpenLU
open OpenLU.CoreTypes
open System.Numerics
open RakDotNet
open System.Reflection
open OpenLU.Attributes
module GameComponent =
    

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

    module ReplicaComponent =
        type replicaComponent(parent,name) =
            inherit Component(parent,name)
            abstract member Construct : BitStream -> unit
            default this.Construct(bitStream) = printfn "Constructing %s" name

        //TODO implement components
        [<ComponentType(4)>]
        type characterComponent(parent) =
            inherit replicaComponent(parent,"Character")
            let id =0
        


