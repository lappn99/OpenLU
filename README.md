# OpenLU

My own implementation of a Lego Universe server emulator in F#

Find similar projects here

https://lusprojects.github.io/

Thanks to [Wincent01](https://github.com/Wincent01)  and [yuwui](https://github.com/yuwui) for developing tools such as [RakDotNet](https://github.com/yuwui/RakDotNet) and [InfectedRose](https://github.com/Wincent01/InfectedRose) to make my life easier

## TODO
* Documentation
* Comments
* Refactor by putting packet structures as their own type

## Database
Uses MySql for the database later on I hope to make the SQL Provider up to the user but thats not a focus right now
so for now to use it you need MySQL
#### Configuring Database
1. Install MySql
2. Create file called "cfg.json" in OpenLU.Configuration root (where OpenLU.Configuration.fsproj is)
3. Add the following key/value pair `connectionString:{string}`
4. run `dotnet ef database update` inside a developer console this should update the database (Ill simplify this process later)
