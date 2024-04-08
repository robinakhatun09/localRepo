using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataContext
{
    public class DapperOrmHelper: IDapperOrmHelper
    {
        private readonly IConfiguration _configuration;
        public string ConnectionString {  get; set; }
        public string ProviderName { get; }
        public DapperOrmHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = configuration.GetConnectionString("databasess");
            ProviderName = "NpgSql";
        }
    }
}
