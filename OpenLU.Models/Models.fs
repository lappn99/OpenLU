namespace OpenLU.Models
open System
open System.Net
module rec GameModels = 
    type public User() =  class
        member val Id = 0 with get,set
        member val Username = "" with get,set
        member val Password = "" with get,set
        member val Characters = List.empty<Character> with get,set
        end

    type public Character() = class
        member val Id = 0 with get,set
        member val Name = "" with get,set
        member val DisplayName = "" with get, set
        member val FreeToPlay = false with get,set
        member val ShirtColor = 0 with get,set
        member val ShirtStyle = 0 with get,set
        member val PantsStyle = 0 with get,set
        member val PantsColor = 0 with get,set
        member val HairStyle = 0 with get,set
        member val LH = 0 with get,set
        member val RH = 0 with get,set
        member val Eyebrows = 0 with get,set
        member val Eyes = 0 with get,set
        member val Mouth = 0 with get,set
        member val LastMapInstance = 0 with get,set
        member val LastMapClone = 0 with get,set
        member val LastLogin = 0
        member val UserId = 0 with get,set
        member val User : User = User() with get,set
        end




    


    
