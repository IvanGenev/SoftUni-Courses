using System;

namespace ChangeArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            ChangeArray(myArray);

            Console.WriteLine(string.Join(" ", myArray));
        }

        public static void ChangeArray(int[] array)
        {
            array[0] = 20;
            array[1] = 30;
        }
    }
}
