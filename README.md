


# OpenLU

My own implementation of a Lego Universe server emulator in F# (And a little C# for EntityFramework)

Find similar projects here

https://lusprojects.github.io/

Thanks to [Wincent01](https://github.com/Wincent01)  and [yuwui](https://github.com/yuwui) for developing tools such as [RakDotNet](https://github.com/yuwui/RakDotNet) and [InfectedRose](https://github.com/Wincent01/InfectedRose) to make my life easier


## Disclaimer  
This is a WIP and is still in very early stages, it is not "play" ready in any means

## TODO
* Documentation
* Comments
* Load player in world

## Database
Uses MySql for the database later on I hope to make the SQL Provider up to the user but thats not a focus right now
so for now to use it you need MySQL
#### Configuring Database
1. Install MySql
2. Create file called "cfg.json" in OpenLU.Configuration root (where OpenLU.Configuration.fsproj is)
3. Add the following key/value pair `connectionString:{string}`
4. Add configuration for local Lego universe resource folder in the key/value pair `luResources : {path}`
    * Example: `"luResources": "D:\\Users\\Nathan\\Documents\\LU Complete Client\\LU Complete Client\\LEGO Universe\\client\\res"`
5. In OpenLU.DBContext run `dotnet ef database update` inside a developer console this should update the database (Ill simplify this process later)
