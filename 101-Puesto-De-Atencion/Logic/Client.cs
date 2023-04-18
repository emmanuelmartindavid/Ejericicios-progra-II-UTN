using System.Data.Common;

namespace Logic
{
    public class Client
    {
        private string _name;
        private int _number;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Number
        {
            get => _number;
        }

        public Client(int number)
        {
            _number = number;
        }

        public Client(int number, string name) : this(number)
        {
            _name = name;
        }

        public static bool operator ==(Client left, Client right)
        {
            return (right.Number == left.Number);
        }

        public static bool operator !=(Client left, Client right)
        {
            return !(right == left);
        }

    }
}