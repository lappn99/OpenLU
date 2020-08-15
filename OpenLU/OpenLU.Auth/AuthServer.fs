

namespace OpenLU.Auth

open RakDotNet
open OpenLU.Core
open RakDotNet.RakNet
open System.Net
open System
open OpenLU.Services

open OpenLU.Core
open System.Diagnostics

type AuthServer() = 
    inherit LUServer(1001,"3.25 ND1")
    interface IAuthServerService with
        member this.Start() = this.StartServer()
    member this.Handshake(ipep : IPEndPoint, packet : LUPacket) = 
        Console.WriteLine("Handshake")
        
        let response = BitStream()
        let client_version = packet.Body.ReadUInt32()
        response.WriteUInt64(packet.Header)
        response.WriteUInt32(client_version)
        response.WriteUInt32((uint32)0x93)
        response.WriteUInt32((uint32)1)
        let currentProcess = Process.GetCurrentProcess()
        response.WriteUInt32((uint32)currentProcess.Id)
        response.WriteString("127.0.0.1",33)
        this.Server.Send(response,ipep)
    member this.ClientLogin(ipep: IPEndPoint, packet:LUPacket) =
        let username = packet.Body.ReadString(33,true)
        let pwd = packet.Body.ReadString(41,true)
        Console.WriteLine("Login with Username: {0} and Password {1}",username,pwd)

        
    override this.HandlePacket ipep data =
        
        let luPacket = LUPacket(data)
        Console.WriteLine("Header: {0}",luPacket.Header)
        if luPacket.Header = (uint64)83 then
            this.Handshake(ipep,luPacket)
        else if luPacket.Header = (uint64)339 then
            this.ClientLogin(ipep,luPacket)
        Console.WriteLine("received packet from {0}:{1} with id {2}",ipep.Address,ipep.Port,data.[0]);
    

    
