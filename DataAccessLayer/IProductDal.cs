using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
