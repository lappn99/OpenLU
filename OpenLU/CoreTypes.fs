namespace OpenLU
open RakDotNet
open System
open System.Net
open System.IO.Compression
open System.IO
open RakDotNet.IO
open OpenLU.Tools.Compression
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
            | WorldInfo = 0x02000553
            | ClientLoadComplete = 0x13000453
            | DetailedUserInfo = 0x04000553


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


    module LDF =
        type LDFDataType =
            STRING = 0
            | S32 = 1
            | FLOAT = 3
            | U32 = 5
            | BOOLEAN = 7
            | S64 = 8
            | OBJID = 9
            | BIN = 13
        type ldfEntry = {key:string;dataType:LDFDataType;value:obj}

        let serializeBinary (ldf : seq<ldfEntry>) =
            use stream = new MemoryStream()
            use writer = new BitWriter(stream)
            writer.Write(uint32 (Seq.length ldf)) |>ignore


            let serializeEntry (ldfEntry : ldfEntry) (writer : BitWriter) =
                let keylen = ldfEntry.key.Length
                writer.Write(uint8 (keylen * 2)) |> ignore
                for char in ldfEntry.key.ToCharArray() do
                    writer.Write(byte char)|>ignore
                    writer.Write(byte 0)|>ignore
                let dataType = ldfEntry.dataType
                writer.Write(uint8 dataType)|>ignore
                
                
                let writeString str (writer : BitWriter) =
                    let string = str.ToString()
                    writer.Write(String.length string)
                    for char in string.ToCharArray() do
                        writer.Write(uint8 char)|>ignore
                        writer.Write(uint8 0)|>ignore

                match dataType with
                    | LDFDataType.STRING ->  writeString (ldfEntry.value) |> ignore
                    | LDFDataType.S32 -> writer.Write(ldfEntry.value :?> int32) |> ignore
                    | LDFDataType.FLOAT -> writer.Write(ldfEntry.value :?> float32) |> ignore
                    | LDFDataType.U32 -> writer.Write( ldfEntry.value :?> uint32) |> ignore
                    | LDFDataType.BOOLEAN -> writer.WriteBit(ldfEntry.value :?> bool) |> ignore
                    | LDFDataType.S64 -> writer.Write( ldfEntry.value :?> int64) |> ignore
                    | LDFDataType.OBJID -> writer.Write(ldfEntry.value :?> Int64) |> ignore
                    | _ -> printfn "Unknown datatype: %s" ldfEntry.key

            Seq.iter(fun entry -> serializeEntry entry writer) ldf
            stream.ToArray()

        let compress (data: byte[]) =
            let compressed = Zlib.compress data
            let checksum = Zlib.adler32Checksum compressed
            let compressedLength = Array.length compressed
            let checksumArray  = BitConverter.GetBytes(checksum)
            Array.Reverse checksumArray
            
            let buffer : byte[] = [|byte 0x78;byte 0xDA|]
            let buffer = Array.append buffer compressed 
            Array.append buffer checksumArray

                    






   
        
        


