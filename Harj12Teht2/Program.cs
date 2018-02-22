using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj12Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.Products.Add(new Product("Tomaattisämpyläpussi", 3));
            cart.Products.Add(new Product("Kadonnut elämä ja onni", 666));
            cart.Products.Add(new Product("Kaljaa", 20));
            cart.Products.Add(new Product("Tumma makaroni", 0.30f));
            cart.Products.Add(new Product("Kivennäisvesi - vadelma", 1.3f));
            cart.Products.Add(new Product("Kivennäisvesi - mustikka", 1.3f));

            cart.ShowCartContents();
        }
    }
}
