using System.Reflection;

using Newtonsoft.Json;

using PluginDemo;

var pluginsDirectory = Path.Combine(
    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ??
        throw new InvalidOperationException("Cannot get the main application directory path"),
    "Plugins");

Console.WriteLine($"App: Newtonsoft {typeof(JsonConverter).Assembly.GetName().Version}");

string[] names = ["PluginFoo", "PluginBar"];

var plugins = names.Select(n =>
    new PluginSandbox(Path.Combine(pluginsDirectory, n)).LoadAssemblyByName(n))
    .SelectMany(a => a.GetTypes())
    .Where(t => t.IsAssignableTo(typeof(IPlugin)))
    .Select(t => Activator.CreateInstance(t))
    .Cast<IPlugin>();

foreach (var p in plugins)
{
    Console.WriteLine($"{p.Name}: Newtonsoft {p.NewtonsoftVersion}");
}
