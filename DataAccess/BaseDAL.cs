using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BaseDAL
    {
        public MemberProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new MemberProvider(connectionString);
        }

        public string GetConnectionString()
        {
            string connectionString = null;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            connectionString = config["ConnectionStrings:DefaultConnection"];
            return connectionString;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
