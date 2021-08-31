using System;

namespace ClassCat
{
    public class Cat
    {
        // Field name
        private string name;
        // Field color
        private string color;

        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }

        // Default constructior
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Method SayMeow
        public void SayMeow()
        {
            Console.WriteLine("Cat {0} said: Meooow!", name);
        }
    }
    class Program
    {
        static void Main()
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMeow();

            Cat secondCat = new Cat("Pepy", "red");
            secondCat.SayMeow();
            Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);

            Cat myCat = new Cat();
            myCat.Name = "Alfred";

            Console.WriteLine("The name of my cat is {0}.", myCat.Name);
            myCat.SayMeow();
        }
    }
}
