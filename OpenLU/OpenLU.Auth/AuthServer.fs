

namespace OpenLU.Auth

open RakDotNet
open OpenLU.Core
open RakDotNet.RakNet
open System.Net
open System
open OpenLU.Services
open RakDotNet.TcpUdp
open OpenLU.Core
open System.Diagnostics
open OpenLU.Core.Enums
type AuthServer() as this = 
    inherit LUServer(1001,"3.25 ND1","Auth Server")

    do
        this.HandlerMap.Add(LUPacketHeader.ClientLogin ,new LoginEvent(this.ClientLogin))

    interface IAuthServerService with
        member this.Start() = this.StartServer()

    member this.ClientLogin(ipep : IPEndPoint) (packet : LUPacket) =
        let username = packet.Body.ReadString(33,true)
        let pwd = packet.Body.ReadString(41,true)
        Console.WriteLine("Login with Username: {0} and Password {1}",username,pwd)
        let response = BitStream()
        response.WriteUInt64((uint64)LUPacketHeader.LoginResponse)
        
        response.WriteByte((byte)0x01)
        response.WriteString("Talk_Like_A_Pirate")
        response.WriteString("",33*7)
        response.WriteUShort((uint16)1)
        response.WriteUShort((uint16)10)
        response.WriteUShort((uint16)64)
        let userkey = String.Concat(Guid.NewGuid().ToString().ToCharArray(0,20))
        Console.WriteLine("New user of : {0}",userkey)
        response.WriteString(userkey,wide = true)
        response.WriteString("127.0.0.1")
        response.WriteString("127.0.0.1")
        response.WriteUShort((uint16)2002)
        response.WriteUShort((uint16)2200)
        response.WriteString("0.0.0.0")
        response.WriteString("00000000-0000-0000-0000-000000000000",37)
        response.WriteUInt((uint32)0)
        response.WriteString("US",3)
        response.WriteByte((byte)0)
        response.WriteByte((byte)0)
        response.WriteULong((uint64)0)
        let err = "Hello there ;D"
        response.WriteUInt16((uint16)err.Length)
        response.WriteString(err,err.Length,wide = true)
        response.WriteInt((int32)4)
        this.Server.Send(response,ipep)

    override this.Handshake (ipep : IPEndPoint) (packet : LUPacket) = 
        
        let response = BitStream()
        let client_version = packet.Body.ReadUInt32()
        
        response.WriteUInt64((uint64)packet.Header)
        response.WriteUInt32(client_version)
        response.WriteUInt32((uint32)0x93)
        response.WriteUInt32((uint32)1)
        let currentProcess = Process.GetCurrentProcess()
        response.WriteUInt32((uint32)currentProcess.Id)
        response.WriteString("127.0.0.1",33)
        this.Server.Send(response,ipep) |> ignore
    
