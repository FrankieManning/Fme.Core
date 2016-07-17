using Fme.Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fme.Core.Domain
{
    public class AuthenticationContext : MongoContext
    {
        public AuthenticationContext() : base("mongodb://localhost:27017", "TestDatabase") {
        }

        public IRepository<User> Users {
            get {
                return new MongoRepository<User>(this);
            }
        }
    }
}
