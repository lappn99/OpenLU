namespace OpenLU

module Attributes =
    
    type ComponentTypeAttribute(componentType : int, order : int) = 
        inherit System.Attribute()
        member this.ComponentType with get() = componentType
        member this.Order with get() = order

