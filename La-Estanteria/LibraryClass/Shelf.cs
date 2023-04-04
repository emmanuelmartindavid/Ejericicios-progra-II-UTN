using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public class Shelf
    {
        private int _shelfLocation;
        private Product[] _products;

        private Shelf(int capacity)
        {
            _products = new Product[capacity];
        }

        public Shelf(int capacity, int shelfLocation) : this(capacity)
        {
            _shelfLocation = shelfLocation;
        }

        public Product[] GetProducts()
        {
            return _products;
        }

        public static bool operator ==(Shelf shelf, Product product)
        {
            foreach (Product item in shelf.GetProducts())
            {
                if (item == product)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Shelf shelf, Product product)
        {
            return !(shelf == product);

        }

        public static bool operator +(Shelf shelf, Product product)
        {
            if (shelf != product)
            {
                for (int i = 0; i < shelf._products.Length; i++)
                {
                    if (shelf._products[i] is null)
                    {
                        shelf._products[i] = product;
                        return true;
                    }
                }
            }
            return true;
        }

        public static Shelf operator -(Shelf shelf, Product product)
        {
            for (int i = 0; i < shelf._products.Length; i++)
            {
                if (shelf == product)
                {
                    shelf._products[i] = null;
                    break;
                }
            }
            return shelf;
        }

        public static string ShowShelf(Shelf shelf)
        {
            StringBuilder sb = new();
         
            sb.AppendLine($"Ubicacion de estante: {shelf._shelfLocation}");
            foreach (Product item in shelf._products)
            {
                sb.AppendLine($"Producto:\n{Product.ShowProduct(item)}");
            }

            return sb.ToString();
        }
    }
}
