using System.Data;
using System.Data.SqlClient;

namespace Class.Data
{
    public interface IDataManager
    {
        bool InitConnection();
        bool SetConnectionString(string connectionString);
        SqlCommand GetStoredProcCommand(string commandText);
        public SqlCommand CreateCommand(string commandText, CommandType commandType);
    }
}
