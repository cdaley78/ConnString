using Class.ConfigManager;
using Class.Data;
using System;

namespace Class.SqlLogger
{
    public class SqlLogManager: ISqlLogManager
    {
        private readonly IConfigManager _configuration;
        private readonly IDataManager _dataManager;

        public SqlLogManager(IConfigManager configuration, IDataManager dataManager)
        {
            _configuration = configuration;
            _dataManager = dataManager;
        }

        public string ConnectionStringName => _configuration.ConnectionNameFsiTraining;

        public bool InitDb()
        {
            try
            {
                var isConnStringSet = _dataManager.SetConnectionString(_configuration.GetConnectionString(ConnectionStringName));
                var isConnected = _dataManager.InitConnection();
            }
            catch (Exception ex)
            {
                var exceptionMessage = ex.Message;
                
                return false;
            }

            return true;
        }

        public bool InitDb(string connectionStringName)
        {
            throw new NotImplementedException();
        }
    }
}
