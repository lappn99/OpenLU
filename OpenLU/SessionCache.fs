namespace OpenLU
open Microsoft.FSharp.Collections
open OpenLU.CoreTypes
open System
open OpenLU.Services
open System.Collections
open System.Linq
open System.Net
open System.Collections.Generic
type SessionCache() = 
    let mutable _sessions : Dictionary<IPEndPoint,Session> = new Dictionary<IPEndPoint,Session>()
    
    member this.Sessions with get() = _sessions and set(v) = _sessions <- v

    interface ISessionService with 
            member this.NewSession(ipep,session) = 
                this.Sessions.Add(ipep,session)
            
            member this.FindByIp(guid) = 
                 match this.Sessions.ContainsKey(guid) with
                    | true -> Some(this.Sessions.[guid])
                    | false -> None
                
             
                
                

                        

                    






