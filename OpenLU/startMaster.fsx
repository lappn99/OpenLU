open System.Diagnostics


let startAuthServer = new Process();
let openLUExePath = @".\bin\debug\netcoreapp3.1\OpenLU.exe"

startAuthServer.StartInfo.FileName <- openLUExePath
startAuthServer.StartInfo.Arguments <- "-auth 1001"


let startWorldServer = new Process();
startWorldServer.StartInfo.FileName <- openLUExePath
startWorldServer.StartInfo.Arguments <- "-world 2002"

startWorldServer.Start()
startAuthServer.Start()

