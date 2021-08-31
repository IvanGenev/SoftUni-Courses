using System;

namespace Excersize4
{
    public class Collar
    {
        private int size;

        public Collar()
        {
        }
    }

    class Kid
    {
        public void CallTheDog(Dog dog)
        {
            Console.WriteLine("Come, " + dog.Name);
        }

        public void WagTheDog(Dog dog)
        {
            dog.Bark();
        }
    }

    public class Dog
    {
        private string name;
        private int age;
        private double length;
        private Collar collar;

        public Dog(string dogName, int dogAge, double dogLength)
        {
            name = dogName;
            age = dogAge;
            length = dogLength;
            collar = new Collar();
        }

        public string Name
        {
            get { return this.name; }
        }

        public void Bark()
        {
            Console.WriteLine("wow-wow");
        }

        public void DoSomething()
        {
            this.Bark();
        }

        static void Main()
        {
            Dog myDog = new Dog("Buddy", 4, 0.7); // Passing parameters
            Console.WriteLine("My dog " + myDog.name + 
                " is " + myDog.age + " years old " + 
                "and it has length: " + myDog.length + " m.");
            myDog.Bark();
        }
    }
}
