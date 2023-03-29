using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface IProductService
    {
        public void Add(Product entity);
        public void Delete(Product entity);
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Update(Product entity);

    }
}
