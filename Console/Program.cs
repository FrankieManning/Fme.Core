using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    class Program
    {

        public class Products
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }
        }

        static void Main(string[] args)
        {
            //MongoRepository
            MongoRepository<Products> repo = new MongoRepository<Products>("mongodb://localhost:27017", "EmployeeDB");
            //var list = repo.GetAll();
            //Assert.AreEqual(1, list.Count());
        }
    }
}
