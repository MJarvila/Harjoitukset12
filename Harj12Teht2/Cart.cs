using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj12Teht2
{
    class Cart
    {
        public List<Product> Products { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public void ShowCartContents()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine("Korista löytyy {0}, jonka hinta on {1}.", product.Name, product.Price + " euroa");
            }
        }
    }
}
