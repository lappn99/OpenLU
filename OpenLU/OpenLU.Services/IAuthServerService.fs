namespace OpenLU.Services

type IAuthServerService =
    abstract member Start : unit -> unit

type IWorldServerService = 
    abstract member Start : unit ->unit