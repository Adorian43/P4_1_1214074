using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214074
{
    internal class ProductTest_1214074
    {
        static void Main(string[] args)
        {
            /*Product_1214074 myProduct = new Product_1214074();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            Book_1214074 product1 = new Book_1214074("Book", "C# Object Oriented Solution", "100");

            DVD_1214074 product2 = new DVD_1214074("She's Hulk", "110");

            //Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} pages", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
