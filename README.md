# Dataprocessing API client
 
This repository contains all the code for the API client.

## Compiling the client
You can choose to compile the client yourself, or grab the latest one from the releases tab.

### Requirements
- Visual Studio 2019 v16.4.5
- .NET Framework v4.8.03752
- NuGet packages Newtonsoft.Json v12.0.3 and Newtonsoft.Json.Schema v3.0.13

Release 1.0 was tested with these exact version numbers. Your mileage may vary.

### Compiling the client
Open the project in Visual Studio using the dp-client.sln file. Next, install all required NuGet packages. Now choose Release in the dropdown menu where it says debug. Finally, go to Build -> Build Solution. The final executable will be located in `./dp-client/bin/Release/`. Note, however, that the program will not work without the other files. Enjoy!