namespace OpenLU
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
open OpenLU.DBContext
open System
open System.Net
open OpenLU.CoreTypes
module Services = 
    type IAuthServerService =
        abstract member Start : unit -> unit
    
    type IWorldServerService = 
        abstract member Start : unit ->unit
    type IDatabasebaseService =
        abstract member GetContext : unit -> BaseContext
    type ISessionService =
        abstract member NewSession : Guid * Session -> unit
        abstract member GetSession : Guid -> Option<Session>
        abstract member FindByIp : IPEndPoint -> Option<Session>
    module ServiceProvider = 
        let private serviceInitialization() = 
            lazy ServiceCollection()
        
        let mutable private currentCollection = serviceInitialization()
        
        let RegisterService<'T when 'T : not struct>(implementation : 'T) =  
            currentCollection.Value.AddSingleton<'T>(implementation) |> ignore
        
        let private serviceProviderInitialzation() =
            lazy currentCollection.Value.BuildServiceProvider()

        let mutable private currentProvider = serviceProviderInitialzation()
       
        let GetService<'T>() =
            currentProvider.Value.GetService<'T>()



            
        
            
            
        

