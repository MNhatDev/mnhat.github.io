using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_OPP
{
    class Program
    {
        //class animal
        //{
        //    public double Weight;
        //    public double Height;
        //    public void info()
        //    {
        //        Console.WriteLine("Height : " + Height + "    Weight : " + Weight);
        //    }
        //}
        class Cat  //Vi du ve parameter
        {
            public double Weight;
            public double Height;
            public Cat()  //parameter co tham so 
            {
                Weight = 200;
                Height = 55;
            }
            public Cat(int w, int h)  //parameter co tham so truyen vao
            { 
                Weight = w;
                Height = h;
            }
            public void info()
            {
                Console.WriteLine("Height : " + Height + "    Weight : " + Weight);

            }
          
        }
        static void Main(string[] args)
        {
            //animal Dog = new animal(); 
            //Dog.Weight = 5;
            //Dog.Height = 10;

            //animal Cat = new animal();
            //Cat.Weight = 3;
            //Cat.Height = 8;
            //Cat.info();
            //Dog.info();
            //Console.ReadKey();



            Cat WhileCat = new Cat();
            WhileCat.info();
            Cat BlackCat = new Cat(327, 100);
            BlackCat.info();
            Console.ReadKey();
        }
    }
}
