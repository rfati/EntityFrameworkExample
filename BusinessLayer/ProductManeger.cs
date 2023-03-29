using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class ProductManeger : IProductService
    {
        ProductDal _productDal = new ProductDal();
        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
