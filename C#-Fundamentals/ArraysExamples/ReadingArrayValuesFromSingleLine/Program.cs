using System;
using System.Linq;

namespace ReadingArrayValuesFromSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //line = line.Replace("  ", " ");
            //string[] tokens = line.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
