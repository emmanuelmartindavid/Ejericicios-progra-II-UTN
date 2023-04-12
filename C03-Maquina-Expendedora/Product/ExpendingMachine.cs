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
            Stack<Product> pepsi = new(GetRandomCollection(new Product("Pepsi", 100), 5));

            Stack<Product> fanta = new(GetRandomCollection(new Product("Fanta", 90), 5));

            Stack<Product> sprite = new(GetRandomCollection(new Product("Sprite", 110), 5));

            Products = new Dictionary<int, Stack<Product>>
            {
                { 1, pepsi },
                { 2, fanta },
                { 3, sprite },
                { 4, new Stack<Product>(GetRandomCollection(new Product("Manaos", 100), 5)) },
                { 5, new Stack<Product>(GetRandomCollection(new Product("Pepsi Max", 100), 5)) },
                { 6, new Stack<Product>(GetRandomCollection(new Product("Coca Cola Zero", 100), 5)) },
                { 7, new Stack<Product>(GetRandomCollection(new Product("Fanta Zero", 100), 5)) },
                { 8, new Stack<Product>(GetRandomCollection(new Product("Sprite Zero", 100), 5)) },
                { 9, new Stack<Product>(GetRandomCollection(new Product("Manaos Zero", 100), 5)) },
                { 10, new Stack<Product>(GetRandomCollection(new Product("Pepsi Zero", 100), 5)) }
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

