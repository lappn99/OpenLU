namespace OpenLU
open OpenLU.Services
open System
open OpenLU.DBContext
open OpenLU.DBContext.Client



module LUDatabase =
    let private initContext() = new MySqlContext()
    let getContext() = initContext()

module CDClientDatabase = 
    let getContext() =  new CDContext()

    let getBrickColor (context:CDContext) (colorId: uint32) =
        query {
            for brickColor in context.BrickColors do
            where( brickColor.Id.Value = int64 colorId)
            exactlyOne
        }


    


    
            
        
            

