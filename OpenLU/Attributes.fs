namespace OpenLU

module Attributes =
    
    type ComponentTypeAttribute(componentType : int) = 
        inherit System.Attribute()
        member this.ComponentType with get() = componentType

