namespace OpenLU
open RakDotNet
open System

module CoreTypes =
    type LUPacketHeader =
        HandShake = 0x00000053
        | ClientLogin = 0x00000153
        | LoginResponse = 0x00000553
        | UserSessionInfo = 0x01000453
        | MinifigListRequest = 0x02000453

    type LUPacket = 
        struct
           val Header : LUPacketHeader
           val Body : BitStream
           new(data : byte[]) = {
               
               Header = enum<LUPacketHeader>(BitConverter.ToInt32(data.[0..3], 0))
               Body = BitStream(data.[8..])
           }
        end
    module Events =
        open System.Net
        
        
        type NewConnectionEvent = delegate of IPEndPoint -> unit
        type HandlePacketEvent = delegate of IPEndPoint * byte[] ->unit
        type DisconnectionEvent = delegate of IPEndPoint -> unit
        
        type HandshakeEvent = delegate of IPEndPoint * LUPacket -> unit
        type LoginEvent = delegate of IPEndPoint * LUPacket -> unit

