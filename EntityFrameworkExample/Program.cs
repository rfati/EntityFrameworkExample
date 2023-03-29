using BusinessLayer;
using Entities;
using System;


namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger();

            Product product = new Product();
            product.ProductName = "Rıfat İŞLER";
            product.CategoryId = 2;
            productManeger.Add(product);
            foreach (var item in productManeger.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
