using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Dog
    {
        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public static int AverageLive { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Hey from dog!");
        }

        public static void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
}
