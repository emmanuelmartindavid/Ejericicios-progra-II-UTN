namespace Logica
{
    public class User
    {
        private string name;
        private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }


        public string GetName()
        {
            return this.name;
        }

        internal bool CheckPassword(string password)
        {
            return this.password == password;
        }
    }
}