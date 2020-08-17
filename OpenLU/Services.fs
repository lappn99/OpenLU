namespace OpenLU
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
module Services = 
    type IAuthServerService =
        abstract member Start : unit -> unit
    
    type IWorldServerService = 
        abstract member Start : unit ->unit
    type IDatabasebaseService =
        abstract member Start : unit -> unit
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



            
        
            
            
        

