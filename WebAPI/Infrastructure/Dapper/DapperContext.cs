using Microsoft.Data.SqlClient;
using System.Data;

namespace WebAPI.Infrastructure.Dapper
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            _connectionString = configuration.GetConnectionString(hostEnvironment.IsDevelopment() ? "SqlConnection" : "TestSqlConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
