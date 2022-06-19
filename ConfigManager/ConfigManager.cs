using Microsoft.Extensions.Configuration;

namespace Class.ConfigManager
{
    public class ConfigManager : IConfigManager
    {
        private readonly IConfiguration _configuration;

        public ConfigManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CmsPlusConnectionName => _configuration["ConnectionStrings:CmsPlus"];

        public IConfigurationSection GetConfigurationSection(string Key)
        {
            return _configuration.GetSection(Key);
        }

        public string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString(connectionName);
        }
    }
}
