namespace Logic
{

    public class Product
    {
        private string _productName;
        private int _productCode;
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

        public int ProductCode
        {
            get => _productCode;
            private set => _productCode = value;

        }

        public Product(string productName, decimal productPrice)
        {

            ProductName = productName;
            ProductPrice = productPrice;
            //ProductCode = CreateRandomCode();
            ProductCode = CreateUniqueCode();


        }

        /*  public static int CreateRandomCode()
          {
              Random random = new();

              int number = random.Next(1, 1000);
              int test = number.CompareTo(number);

              if (number != 0 && test != 0)
              {
                  return number;
              }

              return number;
          }*/

        private static HashSet<int> usedCodes = new HashSet<int>();
        private static Random random = new Random();

        public static int CreateUniqueCode()
        {
            int code;
            do
            {
                code = random.Next(10000, 100001);
            }
            while (usedCodes.Contains(code));
            usedCodes.Add(code);
            return code;
        }
        public override string ToString()
        {
            return $"{ProductName} - Precio: {ProductPrice} - Codigo: {ProductCode}";
        }
    }
}