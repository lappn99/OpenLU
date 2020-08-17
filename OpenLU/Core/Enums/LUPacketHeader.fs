namespace OpenLU.Core.Enums

type LUPacketHeader =
    HandShake = 0x00000053
    | ClientLogin = 0x00000153
    | LoginResponse = 0x00000553
    | UserSessionInfo = 0x01000453
    | MinifigListRequest = 0x02000453
