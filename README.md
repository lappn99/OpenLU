


# OpenLU

Lego Universe server emulator in F# (C# for EntityFramework stuff)

Find similar projects here

https://lusprojects.github.io/

Thanks to [Wincent01](https://github.com/Wincent01)  and [yuwui](https://github.com/yuwui) for developing tools such as [RakDotNet](https://github.com/yuwui/RakDotNet) and [InfectedRose](https://github.com/Wincent01/InfectedRose) to make my life easier


## Disclaimer  
* This is a WIP and is still in very early stages, it is not "play" ready in any means    
* This project is not affiliated with The Lego Group or Lego
* Since its a personal project, and as of now im the sole developer do not expect work to be done on a consistent basis, there may be months long stretches where I dont do anywork on this and then come along and do a bunch in a weekend.

## TODO
* Implement components required for player
* Support for LDF XML data type

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
See [openlu-setuptool](https://github.com/MashedTatoes/openlu-setuptool)


### Use
* Servers can be started indiviudally in their own process or at the same time in the same process
* Command line arguments to start a server:
  * `[-auth/-world] [port]`
  * Example: `./OpenLU.exe -world 2002`
* To start both in the same process simply put `-all` as the first argument, the port is not needed and will start the Auth and World servers in ports 1001 and 2002 respectively
* All these variations are already setup in Visual Studio, they are under Debug>Profile in the properties for the 'OpenLU' project
* startMaster.bat is located in the OpenLU project folder which will start both servers in seperate processes automatically
* For debugging/developing I reccomend to just use the 'OpenLU' profile


## Contribution
Feel free to contribute anytime, all help is appreciated

## [discord](https://discord.gg/g2yhhyJTj9) for those interested
