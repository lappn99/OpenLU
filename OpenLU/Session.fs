namespace OpenLU
open Microsoft.FSharp.Collections
open OpenLU.CoreTypes
open System
open OpenLU.Services
open System.Collections
open System.Linq
open System.Net
open System.Collections.Generic
open OpenLU.LUDatabase
open OpenLU.Models
module Session =

    let initialze() = 
        use db = LUDatabase.getContext()
        db.UserSessions.RemoveRange(db.UserSessions)
        db.SaveChanges()

    let newSession (ipep : IPEndPoint) guid (user: GameModels.User) =
        use db = LUDatabase.getContext()
        let userSession = new Models.GameModels.UserSession()
        userSession.Id <- guid
        userSession.EndPoint <- ipep.Address.ToString()
        userSession.Port <- ipep.Port
        userSession.UserId <- user.Id
        
        let result = db.UserSessions.Add(userSession)

        db.SaveChanges()
    let findByIp (ip : IPEndPoint) =
        let sessions = LUDatabase.getContext().UserSessions

        let session = sessions.Where(fun session -> session.EndPoint = ip.Address.ToString() && session.Port = ip.Port).FirstOrDefault()
        if session.Port = IPEndPoint.MinPort then None else Some(session)
    let remove ipep =
        use db = LUDatabase.getContext()
        let session = findByIp(ipep)
        match session with
            | Some(s) -> 
                db.UserSessions.Remove(s) |> ignore
                db.SaveChanges() |> ignore
                true
            | _ -> false
            
        



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
            member this.RemoveSession ipep =
                this.Sessions.Remove(ipep)
                
             
                
                

                        

                    






