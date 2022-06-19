using Microsoft.Extensions.Configuration;

namespace Class.ConfigManager
{
    public interface IConfigManager
    {
        public string CmsPlusConnectionName { get; }
        public string GetConnectionString(string connectionName);
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
