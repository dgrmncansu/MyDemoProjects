using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal
    {
        List<Product> GETAll();

        void Add(Product product);

        void UPdate(Product product);
        void Delete(Product product);
        List<product> GetAllByCategory(int CategoryId);


    }
}
