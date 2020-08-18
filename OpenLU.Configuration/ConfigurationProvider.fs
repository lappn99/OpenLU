namespace OpenLU.Configuration
open Microsoft.Extensions.Configuration

module public ConfigurationProvider = 
    let private initialze() = 
        let create = fun() -> ConfigurationBuilder().AddJsonFile("cfg.json").Build()
        Lazy.Create(create)
    let mutable private currentConfig = initialze()
    let public GetConfig() = currentConfig.Value
        

