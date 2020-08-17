namespace OpenLU
open OpenLU.Services
open OpenLU.Services

module LegoUniverse = 
    let Start() =
        ServiceProvider.GetService<IAuthServerService>().Start(
        ServiceProvider.GetService<IWorldServerService>().Start()
        

