namespace OpenLU
open Microsoft.FSharp.Collections
open OpenLU.CoreTypes
open System
open OpenLU.Services
type SessionCache() = 
    let mutable _sessions : Map<string,Session> = Map.empty
    
    member this.Sessions with get() = _sessions and set(v) = _sessions <- v

    interface ISessionService with 
            member this.NewSession(key,session) = 
                this.Sessions <- this.Sessions.Add(key,session)
            
            member this.GetSession(key) = 
                 match this.Sessions.ContainsKey(key) with
                    | true -> Some(this.Sessions.[key])
                    | false -> None
                        

                    






