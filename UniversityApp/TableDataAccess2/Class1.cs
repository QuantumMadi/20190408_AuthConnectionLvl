using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace TableDataAccess2
{
    public class CommonTableDataService
    {
        private readonly string _connectionString;
        private readonly string _ownerName;
        private readonly DbProviderFactory _providerFactory;

        public CommonTableDataService()
        {
            _connectionString = ConfigurationManager
        }
    }
}