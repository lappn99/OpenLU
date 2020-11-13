namespace OpenLU

module Components =
    type IComponent =
        abstract member Construct<'T when 'T :> IComponent> : 'T -> byte[]


