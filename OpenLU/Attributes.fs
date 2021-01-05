namespace OpenLU

open System

module Attributes =
    
    type ComponentTypeAttribute(componentType : int, order : int) = 
        inherit System.Attribute()
        member this.ComponentType with get() = componentType
        member this.Order with get() = order

    let compareComponentType (component1 : ComponentTypeAttribute) (component2 : ComponentTypeAttribute) =
        if component1.Order > component2.Order then 1 else -1



