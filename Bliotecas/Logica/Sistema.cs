using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Sistema
    {
        static User[] registerUsers;



        //static User user1;

        static Sistema()
        {
            registerUsers = new User[8];
            //user1 = new("Emma", "1234");
            LoadHarCodeUsers();

        }

        private static void LoadHarCodeUsers()
        {
            registerUsers[0] = new("Emma", "1234");
            registerUsers[1] = new("Jose", "5467");
            registerUsers[2] = new("Romina", "5456");
            registerUsers[3] = new("Emilia", "8632");
            registerUsers[4] = new("Mirna", "7676");

        }

        public static bool ValidateUser(string name, string password)
        {
            if (string.IsNullOrEmpty(name.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                return false;
            }

            for (int i = 0; i < registerUsers.Length; i++)
            {
                if (name.Trim().ToUpper() == registerUsers[i].GetName().Trim().ToUpper())
                {
                    return registerUsers[i].CheckPassword(password);

                }
            }
            return true;
        }
    }
}
