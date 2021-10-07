using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation

        //nasıl çagırılacağı yer
        public void Add(Product product)//101
        {

            Console.WriteLine(product.ProductName + "   eklendi. ");
        }
        public void Update(Product product)
        {

            Console.WriteLine(product.ProductName + "   güncellendi. ");
        }


    }
}
