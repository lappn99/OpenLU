namespace OpenLU
open OpenLU.Services
open OpenLU.Services
open OpenLU.Models
module LegoUniverse = 
    let Start() =
            ServiceProvider.GetService<IAuthServerService>().Start()
            ServiceProvider.GetService<IWorldServerService>().Start()
            
            
        
        
        

