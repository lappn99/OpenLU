namespace OpenLU
open OpenLU.Services
open System
open OpenLU.DBContext
open OpenLU.DBContext.Client
open OpenLU.Configuration


module LUDatabase =
    let private initContext() = 
        let provider = ConfigurationProvider.GetConfig().["provider"]
        match provider.ToLower() with
            | "mysql" -> new MySqlContext() :> BaseContext
            | "sqlite" -> new SqliteContext() :> BaseContext
            | _ -> new MySqlContext() :> BaseContext


        
    let getContext() = initContext()

module CDClientDatabase = 
    let getContext() =  new CDContext()

    let getBrickColor (context:CDContext) (colorId: uint32) =
        query {
            for brickColor in context.BrickColors do
            where( brickColor.Id.Value = int64 colorId)
            exactlyOne
        }


    


    
            
        
            

