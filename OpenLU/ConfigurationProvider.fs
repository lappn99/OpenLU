namespace OpenLU
open Microsoft.Extensions.Configuration
module ConfigurationProvider = 
    let private initialze() = 
        let create = fun() -> ConfigurationBuilder().AddJsonFile("cfg.json").Build()
        Lazy.Create(create)
    let mutable private currentConfig = initialze()
    let GetConfig() = currentConfig.Value
        

