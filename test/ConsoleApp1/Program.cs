using Fme.Core.Dal;
using Fme.Core.Domain;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {


        public class Product
        {
            public ObjectId _id;            
            public string ProductName { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }
        }

        public static void Main(string[] args)
        {
            User user = new User();
            user.Name = "User1";            

            AuthenticationContext context = new AuthenticationContext();
            context.Users().Insert(user);
            var users = context.Users().GetAll();

            //MongoRepository repo = new MongoRepository("mongodb://localhost:27017", "EmployeeDB");
            //repo.Insert<Product>(product);
            //var list = repo.GetAll<Product>().ToList();
            
        }
    }
}
