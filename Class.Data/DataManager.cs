using System;
using System.Data;
using System.Data.SqlClient;

namespace Class.Data
{

    public class DataManager: IDataManager
    {
        private SqlConnection _conn;
        private SqlCommand _cmd;
        private const int _commandTimeout = 0;
        private Exception _error = null;

        private string _connectionString;

        public bool InitConnection()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (Exception ex)
            {
                _error = ex;
                return false;
            }

            return true;
        }

        public SqlCommand GetStoredProcCommand(string commandText)
        {
            return CreateCommand(commandText, CommandType.StoredProcedure);
        }

        public SqlCommand CreateCommand(string commandText, CommandType commandType)
        {
            _cmd = new SqlCommand(commandText, _conn);
            _cmd.CommandType = commandType;
            _cmd.CommandTimeout = _commandTimeout;

            return _cmd;
        }

        public bool SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;

            return true;
        }
    }
}
