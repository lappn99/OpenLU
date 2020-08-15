namespace OpenLU.Core

open System
open RakDotNet

type LUPacket = 
     struct
        val Header : uint64
        val Body : BitStream
        new(data : byte[]) = {
            Header = BitConverter.ToUInt64(data.[0..7],0)
            Body = BitStream(data.[8..])
        }
     end
     

