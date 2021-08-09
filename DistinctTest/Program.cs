using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product[] products = { new Product { Name = "apple", Code = 9 },
                       new Product { Name = "orange", Code = 4 },
                       new Product { Name = "apple", Code = 9 },
                       new Product { Name = "lemon", Code = 12 } };

            //Exclude duplicates.

            List<Product> noduplicates =
                products.Distinct().ToList();

            foreach (var product in noduplicates)
                Console.WriteLine(product.Name + " " + product.Code);

            /*
                This code produces the following output:
                apple 9
                orange 4
                lemon 12
            */
        }
    }
}
