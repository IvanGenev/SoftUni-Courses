using System;

namespace Example3
{
    // Class declaration
    public class Dog
    {
        // Openinv brace of the class body

        // Field declaration
        private string name;

        // Constructor declaration (parametless emtpy construction)
        public Dog()
        {
        }

        // Another constructor declaration
        public Dog(string name)
        {
            this.name = name;
        }

        // Property declaration
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method declaration
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!",
                name ?? "[unnamed dog]");
        }

        static void Main()
        {
            string firstDogName = null;
            Console.WriteLine("Write first dog name: ");
            firstDogName = Console.ReadLine();

            // Using a constructor to create a dog with specified name
            Dog firstDog = new Dog(firstDogName);

            // Using a constructor to create a dog with a default name
            Dog secondDog = new Dog();

            Console.WriteLine("Write second dog name: ");
            string secondDogName = Console.ReadLine();

            // Using property to set the name of the dog
            secondDog.Name = secondDogName;

            // Creating a dog with a default name
            Dog thirdDog = new Dog();

            Console.WriteLine("Write third dog name: ");
            string thirdDogName = Console.ReadLine();

            // Using property to set the name of the dog
            thirdDog.Name = thirdDogName;

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
        // Closing brace of the class body
    }
}
