namespace OpenLU.Core

open System.Net


type NewConnectionEvent = delegate of IPEndPoint -> unit
type HandlePacketEvent = delegate of IPEndPoint * byte[] ->unit
type DisconnectionEvent = delegate of IPEndPoint -> unit

type HandshakeEvent = delegate of IPEndPoint * LUPacket -> unit
type LoginEvent = delegate of IPEndPoint * LUPacket -> unit