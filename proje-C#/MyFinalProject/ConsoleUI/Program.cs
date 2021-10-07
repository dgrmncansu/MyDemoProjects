using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            productManager productmanager = new productManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
