using Class.ConfigManager;

namespace Class.Data
{

    public class DataManager
    {
        private readonly IConfigManager _configuration;

        public DataManager(IConfigManager configuration)
        {
            _configuration = configuration;
        }

        public string GetCmsConnectionString()
        {
            return _configuration.GetConnectionString(_configuration.CmsPlusConnectionName);
        }

    }
}
