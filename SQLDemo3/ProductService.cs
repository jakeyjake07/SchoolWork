using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace SQLDemo3
{
    public class ProductService
    {
        private readonly AppDbContext db;

        public ProductService()
        {
            db = new AppDbContext();
        }


        //Add product to database
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            System.Console.WriteLine("Product added successfully");
        }


        //Read all prodcuts in the database
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        //Read a specific product in the database
        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }
    }
}