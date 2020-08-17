namespace OpenLU
open OpenLU.Services
type LegoUniverse = {AuthService : IAuthServerService; WorldService : IWorldServerService}

module LegoUniverse = 



    type LegoUniverse(authService : IAuthServerService, worldService: IWorldServerService) as this =
    
        let _authService : IAuthServerService = authService
        let _worldService : IWorldServerService = worldService

        member this.AuthService with get() = _authService
        member this.WorldService with get() = _worldService

        member this.Start() =
            this.AuthService.Start()
            this.WorldService.Start()
        

