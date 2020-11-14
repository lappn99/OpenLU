namespace OpenLU
open OpenLU.CoreTypes
open System.Numerics
open RakDotNet
open System.Reflection
open OpenLU.Attributes
open OpenLU.GameObject
module GameComponent =
    

    type transform(pos, rot, parent)=
        inherit Component.``component``(parent,"Transform")
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
            inherit Component.``component``(parent,name)
            abstract member Construct : BitStream -> unit
            default this.Construct(bitStream) = printfn "Constructing %s" name

        //TODO implement components
        [<ComponentType(4,1)>]
        type characterComponent(parent : GameObject.player) =
            inherit replicaComponent(parent,"Character")
            override this.Construct bitStream = 
                let character = parent.Character
                //Part 1
                bitStream.WriteBit(true)
                bitStream.WriteBit(false)
                bitStream.WriteByte(byte 0)

                //Part 2
                bitStream.WriteBit(true)
                bitStream.WriteUInt32(character.Level)
                
                //Part 3
                bitStream.WriteBit(true);
                bitStream.WriteBit(false);
                bitStream.WriteBit(true);

                //Part 4
                bitStream.WriteBit(false);
                bitStream.WriteBit(false);
                bitStream.WriteBit(false);
                bitStream.WriteBit(false);
                bitStream.WriteUInt32(character.HairColor)
                bitStream.WriteUInt32(character.HairStyle)
                bitStream.WriteUInt32(uint32 0)
                bitStream.WriteUInt32(character.ShirtColor)
                bitStream.WriteUInt32(character.PantsColor)
                bitStream.WriteUInt32(uint32 0)
                bitStream.WriteUInt32(uint32 0)
                bitStream.WriteUInt32(character.Eyebrows)
                bitStream.WriteUInt32(character.Eyes)
                bitStream.WriteUInt32(character.Mouth)
                bitStream.WriteUInt64(uint64 character.User.Id)
                bitStream.WriteUInt64(uint64 0)
                bitStream.WriteUInt64(uint64 0)
                bitStream.WriteBit(character.FreeToPlay)
                bitStream.WriteUInt64(character.Currency)
                bitStream.WriteUInt64(character.BricksCollected)
                bitStream.WriteUInt64(character.SmashablesSmashed)
                bitStream.WriteUInt64(character.QuickBuildsCollected)
                bitStream.WriteUInt64(character.EnemiesSmashed)
                bitStream.WriteUInt64(character.RocketsUsed)
                bitStream.WriteUInt64(character.MissionsCompleted)
                bitStream.WriteUInt64(character.PetsTamed)
                bitStream.WriteUInt64(character.ImaginationPowerUps)
                bitStream.WriteUInt64(character.LifePowerUps)
                bitStream.WriteUInt64(character.ArmorPowerUps)
                bitStream.WriteUInt64(character.DistanceTraveled)
                bitStream.WriteUInt64(character.NumberTimesSmashed)
                bitStream.WriteUInt64(character.TotalDamageTaken)
                bitStream.WriteUInt64(character.TotalDamageHealed)
                bitStream.WriteUInt64(character.TotalArmorRepaired)
                bitStream.WriteUInt64(character.TotalImaginationRestored)
                bitStream.WriteUInt64(character.TotalImaginationUsed)
                bitStream.WriteUInt64(character.TotalDistanceDrivenCar)
                bitStream.WriteUInt64(character.TimeAirbornInRaceCar)
                bitStream.WriteUInt64(character.RacingImaginationPowerUps)
                bitStream.WriteUInt64(character.RacingImaginationCrates)
                bitStream.WriteUInt64(character.RaceCarBoostsActivated)
                bitStream.WriteUInt64(character.WrecksInRaceCar)
                bitStream.WriteUInt64(character.RacingSmashablesSmashed)
                bitStream.WriteUInt64(character.RacesWon)
                bitStream.WriteBit(false)
