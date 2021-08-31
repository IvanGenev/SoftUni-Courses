using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            CheckIfPasswordIsValid(password);
        }

        static void CheckIfPasswordIsValid(string password)
        {
            //bool isLengthValid = password.Length >= 6 && password.Length <= 10;
            //bool isSymbolsValid = true;
            //int digitCounter = 0;


            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (!char.IsLetterOrDigit(password[i]))
            //        isSymbolsValid = false;

            //    if (char.IsDigit(password[i]))
            //        digitCounter++;
            //}

            //bool isContain2Digits = digitCounter > 2;

            // A shorter way:

            bool isLengthValid = password.Length >= 6 && password.Length <= 10;
            bool isSymbolsValid = password.All(char.IsLetterOrDigit);
            bool isContain2Digits = password.Count(char.IsDigit) >= 2;


            if (!isLengthValid)
                Console.WriteLine("Password must be between 6 and 10 characters");
            if (!isSymbolsValid)
                Console.WriteLine("Password must consist only of letters and digits");
            if (!isContain2Digits)
                Console.WriteLine("Password must have at least 2 digits");
            if (isLengthValid && isSymbolsValid && isContain2Digits)
                Console.WriteLine("Password is valid");
        }
    }
}
