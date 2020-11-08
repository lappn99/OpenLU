


# OpenLU

My own implementation of a Lego Universe server emulator in F# (C# for EntityFramework stuff)

Find similar projects here

https://lusprojects.github.io/

Thanks to [Wincent01](https://github.com/Wincent01)  and [yuwui](https://github.com/yuwui) for developing tools such as [RakDotNet](https://github.com/yuwui/RakDotNet) and [InfectedRose](https://github.com/Wincent01/InfectedRose) to make my life easier


## Disclaimer  
* This is a WIP and is still in very early stages, it is not "play" ready in any means    
* This project is not affiliated with The Lego Group or Lego

## TODO
* Documentation
* Comments
* Load player in world
* Create setup tool (Seperate project/repository)
* Implement Sqlite provider/context

## Installation

### Pre requesites
* .NET Core 3.1
* MySQL
* Entity Framework Core Tools
   * [PackageManager Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell)
   * [CLI Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
* Lego Universe complete client 
  * Find list of clients [here](https://docs.google.com/document/d/1XmHXWuUQqzUIOcv6SVVjaNBm4bFg9lnW4Pk1pllimEg/edit) (humanoid/lcdr’s unpacked client is reccomended)

### Configuration
#### Windows:
* See [openlu-setuptool](https://github.com/MashedTatoes/openlu-setuptool)

#### Mac OSX and Linux:

* Create file called "cfg.json" in OpenLU.Configuration root (where OpenLU.Configuration.fsproj is)
* Add the following key/value pair connectionString:{string}
* Add configuration for local Lego universe resource folder in the key/value pair luResources : {path}
    * Example: "luResources": "D:\\Users\\Nathan\\Documents\\LU Complete Client\\LU Complete Client\\LEGO Universe\\client\\res"
* Open command line In OpenLU.DBContext and run `dotnet ef database update` this should update the database (Ill simplify this process later)
* Use the 'fdb_to_sqlite' python script to convert cdclient.fdb to cdclient.db
