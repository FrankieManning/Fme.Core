using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fme.Core.Dal;
using System.Collections.Generic;
using System.Linq;

namespace Fme.Core.DalTests
{
    [TestClass]
    public class UnitTest1
    {
        public class Products {
            public int ProductId { get; set;}
            public string ProductName { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }
        }

        
        [TestMethod]
        public void TestMethod1()
        {
            //MongoRepository<Products> repo = new MongoRepository<Products>("mongodb://localhost:27017", "EmployeeDB");
            //var list = repo.GetAll();
            //Assert.AreEqual(1, list.Count());
        }
    }
}
