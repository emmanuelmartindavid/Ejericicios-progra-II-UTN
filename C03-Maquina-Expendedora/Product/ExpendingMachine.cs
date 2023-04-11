using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ExpendingMachine
    {

        public Dictionary<int, Product> Products { get; set; }

        public ExpendingMachine()
        {
            Products = new Dictionary<int, Product>
             {
                    { 1, new Product("Pepsi", 100) },
                    { 2, new Product("Fanta", 100) },
                    { 3, new Product("Sprite", 100) },
                    { 4, new Product("Manaos", 100) },
                    { 5, new Product("Pepsi Max", 100) },
                    { 6, new Product("Coca Cola Zero", 100) },
                    { 7, new Product("Fanta Zero", 100) },
                    { 8, new Product("Sprite Zero", 100) },
                    { 9, new Product("Manaos Zero", 100) },
                    { 10, new Product("Pepsi Zero", 100) }
             };
        }
    }
}
