namespace OpenLU
open OpenLU.Services
open System
open OpenLU.DBContext




module LUDatabase =
    let private initContext() = new MySqlContext()
    let getContext() = initContext()

module CDClientDatabase = 
    let private initContext() = new SQLiteContext()
    let getContext() = initContext()

type LUDatabase() =
    interface IDatabaseService with
        member this.GetContext() = LUDatabase.getContext() :> BaseContext

type CDClientDatabase() = 
   interface IDatabaseService with
    member this.GetContext() = CDClientDatabase.getContext() :> BaseContext


    
            
        
            

