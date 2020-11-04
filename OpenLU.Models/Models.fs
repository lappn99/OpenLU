namespace OpenLU.Models
open System
open System.Net
module rec GameModels = 
    type public User() =  class
        member val Id = 0 with get,set
        member val Username = "" with get,set
        member val Password = "" with get,set
        member val Characters = System.Collections.Generic.List<Character>() with get,set
        end

    type public Character() = class
        member val Id  = (int64)0 with get,set
        member val Name = "" with get,set
        member val DisplayName = "" with get, set
        member val FreeToPlay = false with get,set
        member val ShirtColor  = uint32 0 with get,set
        member val ShirtStyle = uint32 0 with get,set
        member val PantsStyle =uint32 0 with get,set
        member val PantsColor = uint32 0 with get,set
        member val HairStyle = uint32 0 with get,set
        member val HairColor = uint32 0 with get,set
        member val LH = uint32 0 with get,set
        member val RH = uint32 0 with get,set
        member val Eyebrows = uint32 0 with get,set
        member val Eyes = uint32 0 with get,set
        member val Mouth = uint32 0 with get,set
        member val LastMapInstance = uint16 0 with get,set
        member val LastMapClone = uint32 0 with get,set
        member val LastLogin = uint64 0 with get,set
        member val UserId = 0 with get,set
        member val User : User = User() with get,set
        end






    


    
