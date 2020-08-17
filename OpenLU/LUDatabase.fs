namespace OpenLU
open OpenLU.Services
open System
open System.Data.SqlClient
open MySql.Data.MySqlClient

module rec LUDatabase =
    type MySqlProvider() = 
        interface IDatabasebaseService with 
            member this.Start() = MySqlProvider.start this
                
    module MySqlProvider = 
        let start(provider) = 
            let config = ConfigurationProvider.GetConfig()
            
            using(new MySqlConnection(config.["connectionString"])) 
                (fun conn -> 
                    let command = new MySqlCommand("select * from openlu.users",conn)
                    command.Connection.Open()
                    using(command.ExecuteReader()) (fun reader ->
                        while(reader.Read()) do
                            Console.WriteLine("{0} {1}", reader.[0], reader.[1])))   
            
        
            

