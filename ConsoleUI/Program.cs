using Business.Concrete;
using DateAccess.Concrete.Entityframework;
using DateAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}
