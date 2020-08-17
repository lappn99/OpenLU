namespace OpenLU.Core

open System
open RakDotNet
open OpenLU.Core.Enums
type LUPacket = 
     struct
        val Header : LUPacketHeader
        val Body : BitStream
        new(data : byte[]) = {
            
            Header = enum<LUPacketHeader>(BitConverter.ToInt32(data.[0..3], 0))
            Body = BitStream(data.[8..])
        }
     end
     

