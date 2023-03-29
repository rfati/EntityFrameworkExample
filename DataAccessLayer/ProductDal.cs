using Entities;
using EntityFrameworkExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductDal : IProductDal
    {

        public void Add(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                context.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var target = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                context.Remove(target);
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Products.ToList();
            }
        }
        public Product GetById(int productId)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductId == productId);
            }
        }

        public void Update(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var target = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                target.ProductName = product.ProductName;
                target.UnitPrice = product.UnitPrice;
                target.UnitsInStock = product.UnitsInStock;
                target.CategoryId = product.CategoryId;
                context.Products.Update(target);
                context.SaveChanges();
            }
        }
    }
}
