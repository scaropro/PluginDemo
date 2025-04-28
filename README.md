# PluginDemo

## Build and run

```powershell
$plugins = "src\MainApp\bin\Debug\net9.0\Plugins"
dotnet publish src\PluginFoo -o "$plugins\PluginFoo"
dotnet publish src\PluginBar -o "$plugins\PluginBar"
dotnet run --project src\MainApp
```
