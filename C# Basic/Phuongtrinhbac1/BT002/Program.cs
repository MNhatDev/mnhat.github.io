using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT002
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB ;
            int a, b;
            double c;
            Console.WriteLine("*********************************");
            Console.WriteLine("*                               *");
            Console.WriteLine("*   Giai phuong trinh 1 nghiem  *");
            Console.WriteLine("*                               *");
            Console.WriteLine("*********************************");
            Console.Write("Nhap so a : ");
            strA = Console.ReadLine();
            Console.Write("Nhap so b : ");
            strB = Console.ReadLine();

            if ((int.TryParse(strA, out a) == false) || (int.TryParse(strB, out b) == false))
            {
                    Console.WriteLine("du lieu nhap sai");
                    Console.ReadKey();
                    return;
            }
            else if (a==0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
             
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("x = 0");

                }
                else
                {
                    c = (double)-b / a;
                    Console.WriteLine("Ket qua x = " + c);
                }
            }
            Console.ReadKey();
        }
    }
}
