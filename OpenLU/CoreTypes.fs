namespace OpenLU
open RakDotNet
open System
open System.Net

module rec CoreTypes =
    module Enums =

        type LUPacketHeader =
            HandShake = 0x00000053
            | ClientLogin = 0x00000153
            | LoginResponse = 0x00000553
            | UserSessionInfo = 0x01000453
            | MinifigListRequest = 0x02000453
            | MinifigListResponse = 0x06000553
            | MinifigCreateRequest = 0x03000453
            | MinifigCreateResponse = 0x07000553
            | UserJoinWorldRequest = 0x04000453


        type LoginResponse =
             SUCCESS = 0x01
            | BANNED = 0x02
            | INVALID_PERM = 0x03
            | INVALID_LOGIN_INFO = 0x06
            | ACCOUNT_LOCKED = 0x07
    type LUPacket = 
        struct
           val Header : Enums.LUPacketHeader
           val Body : BitStream
           new(data : byte[]) = {
               
               Header = enum<Enums.LUPacketHeader>(BitConverter.ToInt32(data.[0..3], 0))
               Body = BitStream(data.[8..])
           }
        end
    
    
    type Session = 
       {
        UserId : int
        UserKey: string} 
    module Events =
        
        type NewConnectionEvent = delegate of IPEndPoint -> unit
        type HandlePacketEvent = delegate of IPEndPoint * byte[] ->unit
        type DisconnectionEvent = delegate of IPEndPoint -> unit
        type ClientPacketEvent = delegate of IPEndPoint * LUPacket -> unit
        type HandshakeEvent = delegate of IPEndPoint * LUPacket -> unit
        type LoginEvent = delegate of IPEndPoint * LUPacket -> unit


   
        
        


