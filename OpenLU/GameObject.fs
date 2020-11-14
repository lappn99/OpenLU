namespace OpenLU
open OpenLU.CoreTypes
open OpenLU.Models


module GameObject =

        type player(character : GameModels.Character,objectInfo : Object.ObjectInformation) =
            inherit Object.object(objectInfo)
            let _character = character
            member this.Character with get() = _character