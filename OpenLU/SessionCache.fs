namespace OpenLU
open Microsoft.FSharp.Collections
open OpenLU.CoreTypes
open System
open OpenLU.Services
open System.Collections
open System.Linq
type SessionCache() = 
    let mutable _sessions : Map<Guid,Session> = Map.empty
    
    member this.Sessions with get() = _sessions and set(v) = _sessions <- v

    interface ISessionService with 
            member this.NewSession(guid,session) = 
                this.Sessions <- this.Sessions.Add(guid,session)
            
            member this.GetSession(guid) = 
                 match this.Sessions.ContainsKey(guid) with
                    | true -> Some(this.Sessions.[guid])
                    | false -> None
            member this.FindByIP(ip) =
                
                

                        

                    






