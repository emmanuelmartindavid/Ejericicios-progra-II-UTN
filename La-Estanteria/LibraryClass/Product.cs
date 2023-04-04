using System.Text;

namespace LibraryClass
{
    public class Product
    {

        private string _brand;
        private string _codeBar;
        private float _price;
        public Product(string brand, string codeBar, float price)
        {
            _brand = brand;
            _codeBar = codeBar;
            _price = price;
        }

        public string GetBrand()
        {
            return _brand;
        }
        public float GetPrice()
        {
            return _price;
        }
     
        public static explicit operator string(Product product)
        {
            return product._codeBar;
        }
        public static bool operator ==(Product product1, Product product2)
        {
            if(!(product1 is null || product2 is null))
            {
                return product1._codeBar == product2._codeBar && product1._brand == product2._brand;
            }
            return false;
        }
        public static bool operator !=(Product product1, Product product2)
        {
            return !(product1 == product2);
        }
        public static bool operator ==(Product product, string brand)
        {
            return product.GetBrand() == brand;
        }
        public static bool operator !=(Product product, string brand)
        {
            return !(product == brand);
        }
        public static string ShowProduct(Product product)
        {
            StringBuilder sb = new();
            sb.AppendLine($"Marca: {product.GetBrand()}");
            sb.AppendLine($"Codigo de barras: {product._codeBar}");
            sb.AppendLine($"Precio: {product.GetPrice():#.00}");
            sb.AppendLine("====================");

            return sb.ToString();
        }
    }
}