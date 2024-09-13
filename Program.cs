using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Linkquery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Categories = new Category[]// Category array initialization with two categories
                 {
                new Category {CategoryId=1,CategoryName="Shirt" },
                new Category {CategoryId=1,CategoryName="Pant" }
                 };
            var Models = new ProductModel[]
                {
                new ProductModel {ModelId=1,ModelName="Mans Shirt" },
                new ProductModel {ModelId=2,ModelName="Mans Pant"},
                new ProductModel {ModelId=3,ModelName="Womans Shirt"},
                new ProductModel {ModelId=4,ModelName="Womans Pant"}
                };
            var Products = new Product[]
                {
                new Product {ProductId=1,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ModelId=1, CategoryId=1, Fixedprice=700, Quantity=4},
                new Product {ProductId=2,ProductName="Casual Pant",PruductNumber=1213,Color="Blue", ModelId=2, CategoryId=2, Fixedprice=800, Quantity=9},
                new Product {ProductId=3,ProductName="Formal Shirt",PruductNumber=1214,Color="Green", ModelId=1, CategoryId=1, Fixedprice=300, Quantity=4},
                new Product {ProductId=4,ProductName="Formal Pant",PruductNumber=1212,Color="Yellow", ModelId=2, CategoryId=2, Fixedprice=400, Quantity=4},
                new Product {ProductId=1,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ModelId=1, CategoryId=1, Fixedprice=700, Quantity=4},

                new Product {ProductId=5,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ModelId=3, CategoryId=1, Fixedprice=700, Quantity=4},
                new Product {ProductId=6,ProductName="Casual Pant",PruductNumber=1213,Color="Blue", ModelId=4, CategoryId=2, Fixedprice=800, Quantity=9},
                new Product {ProductId=7,ProductName="Formal Shirt",PruductNumber=1214,Color="Green", ModelId=3, CategoryId=1, Fixedprice=300, Quantity=4},
                new Product {ProductId=8,ProductName="Formal Pant",PruductNumber=1212,Color="Yellow", ModelId=4, CategoryId=2, Fixedprice=400, Quantity=4},
                new Product {ProductId=9,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ModelId=3, CategoryId=1, Fixedprice=700, Quantity=4},

                };
           

            Console.WriteLine("---------------Joinining Three Table-------------------");
            var Garments = from p in Products// LINQ query to join Products with Categories and Models based on their respective IDs
                           join c in Categories
                           on p.CategoryId equals c.CategoryId
                           join m in Models
                           on p.ModelId equals m.ModelId
                           select new
                           {
                               Product = p.ProductId,
                               Categoryobj = c.CategoryName,
                               Model = m.ModelName,
                               p.ProductName,
                               p.Color,
                               p.Fixedprice,
                           };
            foreach (var x in Garments)
            {
                Console.WriteLine($"{x.ProductName}\t {x.Model}\t{x.Color}\t{x.Fixedprice}");
            }
            Console.ReadLine();





                



        }
    }
}
