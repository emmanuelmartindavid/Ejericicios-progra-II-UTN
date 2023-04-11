namespace Logic
{
    public class Product
    {
        private string _productName;
        //private int _productCode;
        private decimal _productPrice;
        //private string _productDescription;

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
       
        public Product(string productName, decimal productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public override string ToString()
        {
            return $"{ProductName} - Precio: {ProductPrice}";
        }


    }
}