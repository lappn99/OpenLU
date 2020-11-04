namespace OpenLU
open OpenLU.Services
open System
open OpenLU.Configuration.ConfigurationProvider
open System.IO
module LUResources =
    let private resPath() = lazy GetConfig().["luResources"]
    let mutable private resoucePath = resPath()
    let getResourcePath() = resoucePath.Value

    type LocalResourceProvider() =
        interface IResourceService with
            member this.ReadTextAsync path : Async<string> = async{
                let resDir = getResourcePath()
                let fullPath = sprintf "%s/%s" resDir path
                let! text = File.ReadAllTextAsync fullPath |> Async.AwaitTask
                return text} 
                
                
                
                
            


   
        


