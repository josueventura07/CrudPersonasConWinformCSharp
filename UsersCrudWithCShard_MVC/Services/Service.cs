using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UsersCrudWithCShard_MVC.Services
{
    public  class Service : IServices
    {
        public string ConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            return connectionString;
        }
    }
}
