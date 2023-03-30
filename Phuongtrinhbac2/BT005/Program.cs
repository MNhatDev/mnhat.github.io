using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT005
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB, strC;
            int a, b, c;
            double delta,x1,x2;
            Console.Write("nhap so a = ");
            strA = Console.ReadLine();
            Console.Write("nhap so b = ");
            strB = Console.ReadLine();
            Console.Write("nhap so c = ");
            strC = Console.ReadLine();
            if((int.TryParse(strA, out a)==false) || (int.TryParse(strB, out b)==false) || (int.TryParse(strC, out c)==false))
            {
                Console.WriteLine("Du lieu nhap sai !");
                Console.ReadKey();
                return;
            }
            if (a == 0)
            {
                x1 = (double)-c / b;
                x2 = x1;
                Console.WriteLine("Phuong trinh bac nhat X = " + x1);
            }
            else
            {
                delta = (double)b * b - 4 * a * c;
                if(delta<0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if(delta==0)
                {
                    x1 = (-b/2*a);
                    x2 = x1;
                    Console.WriteLine("Phuong trinh co nghiem kep X1=X2 = " + x1);
                }
                else
                {
                    x1 = (-b+Math.Sqrt(delta))/(2*a);
                    x2 = (-b-Math.Sqrt(delta))/(2*a);
                    Console.WriteLine("Phuong trinh co hai nghiem X1= {0} , X2 = {1}",x1,x2);
                }
                Console.WriteLine(delta);
            }
            Console.ReadKey();
        }
    }
}
