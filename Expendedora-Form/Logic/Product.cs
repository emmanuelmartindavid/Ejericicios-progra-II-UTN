namespace Logic
{
    public class Product
    {
        private string _productName;
        private int _productCode;
        private decimal _productPrice;
        private static int lastCode; 


        public string ProductName
        {
            get => _productName;
            private set => _productName = value;
        }
        public decimal ProductPrice
        {
            get => _productPrice;
            private set => _productPrice = value;
        }

        public int ProductCode
        {
            get => _productCode;
            private set => _productCode = value;

        }

        static Product()
        {
            lastCode = 1000;
        }

        public Product(string productName, decimal productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductCode = lastCode++;
        }

        public override string ToString()
        {
            return $"{ProductName} - Precio: {ProductPrice} - Codigo: {ProductCode}";
        }

    }
}