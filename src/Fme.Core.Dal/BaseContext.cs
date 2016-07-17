using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Fme.Core.Dal
{
    public class BaseContext
    {
        public string ConnectionString { get; protected set; }

        public BaseContext(string connectionName) {
            //ConnectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            ConnectionString = connectionName;
        }
    }
}
