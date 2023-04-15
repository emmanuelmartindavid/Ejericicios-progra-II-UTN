namespace Logic
{

    public class Product
    {
        private static HashSet<int> _usedCodes = new();
        private static Random _random = new();
        private string _productName;
        private int _productCode;
        private decimal _productPrice;
     

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

        public Product(string productName, decimal productPrice)
        {

            ProductName = productName;
            ProductPrice = productPrice;
            ProductCode = CreateUniqueCode();


        }

   
        public static int CreateUniqueCode()
        {
            int code;
            do
            {
                code = _random.Next(10000, 100001);
            }
            while (_usedCodes.Contains(code));
            _usedCodes.Add(code);
            return code;
        }
        public override string ToString()
        {
            return $"{ProductName} - Precio: {ProductPrice} - Codigo De Barras: {ProductCode}";
        }
    }
}