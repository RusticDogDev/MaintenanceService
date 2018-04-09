using System.Configuration;

namespace MaintenanceService.Lib.Interfaces.Base
{
    /// <summary>
    /// This interface represents the interface for a config manager.
    /// </summary>
    public interface IConfig
    {
        /// <summary>
        /// Gets the connection strings.
        /// </summary>
        ConnectionStringSettingsCollection ConnectionStrings { get; }
    }
}