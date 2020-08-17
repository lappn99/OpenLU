namespace OpenLU
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Configuration
module Services = 
    type IAuthServerService =
        abstract member Start : unit -> unit
    
    type IWorldServerService = 
        abstract member Start : unit ->unit

    module ServiceProvider = 
        let private serviceCollection = ServiceCollection()
        
            
            
        

