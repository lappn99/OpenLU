namespace OpenLU
open OpenLU.Services
open System
open OpenLU.DBContext

module LUDatabase =
    let private initContext() = lazy new MySqlContext()
    let mutable private currentContext = initContext()
    let getContext() = 
        currentContext.Value

type LUDatabase() as this =
    interface IDatabasebaseService with
        member this.GetContext() = LUDatabase.getContext() :> BaseContext
    
            
        
            

