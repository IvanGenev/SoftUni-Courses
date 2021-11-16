using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayInt = CreateArray<int>(10, 1);
            var arrayString = CreateArray<string>(10, "Ivan");
        }

        static T[] CreateArray<T>(int count, T element)
        {
            T[] result = new T[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = element;
            }
            
            return result;
        }
    }
}
