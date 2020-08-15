namespace OpenLU.Core
open OpenLU.Services

type LegoUniverse(authService : IAuthServerService) as this =
    
    let _authService : IAuthServerService = authService
    member this.AuthService with get() = _authService

    member this.Start() =
        this.AuthService.Start()
    

