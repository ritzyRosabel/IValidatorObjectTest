using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvalidatorObjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username and password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            ValidateCredentials(new LoginModel { Username = username, Password = password});
            Console.ReadLine();
        }

        private static void ValidateCredentials(LoginModel loginModel)
        {

            Console.WriteLine("Pass");
        }
    }
}
