namespace OpenLU
open OpenLU.Services
open System
open OpenLU.Configuration.ConfigurationProvider
open System.IO
open InfectedRose.Luz
open RakDotNet
open RakDotNet.IO
open System.Numerics
module LUResources =
    



    let private resPath() = lazy GetConfig().["luResources"]
    let mutable private resoucePath = resPath()
    let getResourcePath() = resoucePath.Value
    let getZone zoneName =
        let luzFile : LuzFile = LuzFile()
        let path = sprintf "%s/maps/%s" (getResourcePath()) zoneName
        use fileStream = File.OpenRead(path)
        use bitReader = new BitReader(fileStream)
        luzFile.Deserialize(bitReader)
        luzFile
        

    type LocalResourceProvider() =
        interface IResourceService with
            member this.ReadTextAsync path : Async<string> = async{
                let resDir = getResourcePath()
                let fullPath = sprintf "%s/%s" resDir path
                let! text = File.ReadAllTextAsync fullPath |> Async.AwaitTask
                return text} 
                
                
                
                
            


   
        


