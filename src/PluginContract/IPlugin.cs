namespace PluginDemo;

/// <summary>
/// The contrract of the demo plugin.
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Get this plugin name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the NewtonSoft.Json assembly that the plugin uses.
    /// </summary>
    Version? NewtonsoftVersion { get; }
}
