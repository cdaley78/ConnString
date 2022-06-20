using Microsoft.Extensions.Configuration;

namespace Class.ConfigManager
{
    public interface IConfigManager
    {
        public string ConnectionNameFsiTraining { get; }
        public string ConnectionNameFsiTrainingLogger { get; }
        public string GetConnectionString(string connectionName);
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
