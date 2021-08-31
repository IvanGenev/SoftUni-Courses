using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            
            string password = string.Join("", username.Reverse());

            // The below code reverse the string the same like the above with string.Join("", username.Reverse());

            ////string password = string.Empty;

            ////for (int i = userName.Length; i > 0; i--)
            ////{
            ////    password += userName[i];
            ////}

            bool isLoggedin = false;

            for (int i = 0; i < 3; i++)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    isLoggedin = true;
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

            if (!isLoggedin)
            {
                Console.WriteLine($"User {username} blocked!");
            }

            // Another version:

            //for (int i = 0; i < 4; i++)
            //{
            //    string inputPassword = Console.ReadLine();

            //    if (inputPassword == password)
            //    {
            //        Console.WriteLine($"User {userName} logged in.");
            //        break;
            //    }

            //    if (i == 3)
            //    {
            //        Console.WriteLine($"User {userName} blocked!");
            //        break;
            //    }

            //    if (inputPassword != password)
            //    {
            //        Console.WriteLine("Incorrect password. Try again.");
            //    }
            //}
        }
    }
}
