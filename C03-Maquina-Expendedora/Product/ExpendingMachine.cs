using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ExpendingMachine
    {
        public Dictionary<int, Stack<Product>> Products { get; private set; }

        public ExpendingMachine()
        {
            Stack<Product> pepsi = new(GetRandomCollection(new Product("Pepsi", 100), 2));

            Stack<Product> cocaCola = new(GetRandomCollection(new Product("Coca Cola", 90), 2));

            Stack<Product> water = new(GetRandomCollection(new Product("Agua", 110), 2));

            Stack<Product> lays = new(GetRandomCollection(new Product("Lays", 110), 2));

            Stack<Product> pringles = new(GetRandomCollection(new Product("Pringles", 110), 2));

            Stack<Product> doritos = new(GetRandomCollection(new Product("Doritos", 110), 2));

            Stack<Product> kinder = new(GetRandomCollection(new Product("Kinder", 110), 2));

            Stack<Product> oreo = new(GetRandomCollection(new Product("Oreo", 110), 2));

            Stack<Product> tikTak = new(GetRandomCollection(new Product("Tik Tak", 110), 2));

            Products = new Dictionary<int, Stack<Product>>
            {
                { 1, pepsi },
                { 2, cocaCola },
                { 3, water },
                { 4, lays },
                { 5, pringles },
                { 6, doritos },
                { 7, kinder },
                { 8, oreo },
                { 9, tikTak },
            };

        }

        public static ICollection<Product> GetRandomCollection(Product products, int amount)
        {       
            ICollection<Product> collection = new List<Product>();

            while (collection.Count < amount)
            {
                collection.Add(products);
            }
            return collection;
        }
    }


}

