namespace OpenLU

module GameTypes = 
    type Minifigure = 
        {CharId : string
         UnknownU32 : uint32
         CharName : string
         DisplayName: string
         FreeToPlay : bool
         ShirtColor : uint32
         ShirtStyle : uint32
         PantColor : uint32
         HairStyle : uint32
         LH : uint32
         RH : uint32
         Eyebrows : uint32
         Eyes : uint32
         Mouth :uint32
         LastMapInstance : uint16
         LastMapClone : uint32
         LastLogin : uint64
         NumItems : uint16}

