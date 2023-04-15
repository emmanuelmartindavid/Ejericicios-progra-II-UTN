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
            Stack<Product> lays = new(GetCollection(new Product("Lays", 110), 2));
       
            Stack<Product> doritos = new(GetCollection(new Product("Doritos", 110), 2));

            Stack<Product> pringles = new(GetCollection(new Product("Pringles", 110), 2));

            Stack<Product> pepsi = new(GetCollection(new Product("Pepsi", 100), 3));
                
            Stack<Product> cocaCola = new(GetCollection(new Product("Coca Cola", 90), 2));

            Stack<Product> water = new(GetCollection(new Product("Agua", 110), 2));

            Stack<Product> kinder = new(GetCollection(new Product("Kinder", 110), 2));

            Stack<Product> tikTak = new(GetCollection(new Product("Tik Tak", 110), 2));

            Stack<Product> oreo = new(GetCollection(new Product("Oreo", 110), 2));

            Products = new Dictionary<int, Stack<Product>>
            {
                { 1, lays },            
                { 2, doritos },
                { 3, pringles },
                { 4, pepsi },
                { 5, cocaCola },
                { 6, water },
                { 7, kinder },              
                { 8, tikTak },
                { 9, oreo },
            };

        }

        public static ICollection<Product> GetCollection(Product products, int amount)
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
