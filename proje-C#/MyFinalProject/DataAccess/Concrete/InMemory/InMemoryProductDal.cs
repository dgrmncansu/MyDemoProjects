using DataAccess.Abstract;
using DataAccess.Concrete.InMemory
using System;
using System.Collections.Generic;
using System linq;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal


        List<Product>_product;

        public InMemoryProuctDal()
    //Oracle,Sql Server,Postgres,MongoDb
    {
        products = new List<Prroduct>{
            new Product{ProductId=1,Category=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15}
            new Product{ProductId=2,Category=2,ProductName="Kamera",UnitPrice=15,UnitInStock=15}
           new Product{ProductId=3,Category=3,ProductName="Telefon",UnitPrice=15,UnitInStock=15}
          new Product{ProductId=4,Category=4,ProductName="Klavye",UnitPrice=15,UnitInStock=15}
         new Product{ProductId=5,Category=5,ProductName="Fare",UnitPrice=15,UnitInStock=15}
};


        public void Add(Product product)
        {
            _products.Add(product);
        }


        public void Delete(Product product)
        {

            // LINQ- Language Integrated Query
            //Lambda

            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            products.Remove(productToDelete);


        }
    }


    public List<Prpduct product>


//Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul       
{
        product productToDelete = _products.SingleOrDefault(p=> p.ProductId==product.ProductId);
        productToUpdate.productName=product.ProductName;
        productToUpdate.Category=product.CategoryId;
        productToUpdate.UnitPricey=product.Unitprice;
        productToUpdate.UnitInStock=product.UnitInStock;


}
 public List<product> GetAllByCategory(int CategoryId);
   {
         return_products.Where(p=>p.CategoryId== categoryId).ToList();

}



        }

    }
}

