using System;

namespace OPP_5
{
    class animal
    {
        public virtual void speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
    }
    class Cat : animal
    {
        public override void speak()
        {
            Console.WriteLine("Cat is speaking...");
        }
    }
    class Dog : animal
    {
        public override void speak()
        {
            Console.WriteLine("Dog is speaking...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            animal cat = new Cat();
            animal dog = new Dog();
            cat.speak();
            dog.speak();
            Console.ReadKey();
        }
    }
}
