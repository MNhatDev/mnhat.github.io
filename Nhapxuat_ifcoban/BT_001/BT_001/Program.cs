using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1
            //Console.Write("Ho va ten : ");
            //Console.WriteLine("Ten cua ban la  " + Console.ReadLine());
            //Console.ReadKey();

            //Bai 2
            //Console.Write("Ten cua ban la : ");
            //Console.WriteLine("Vang chao " + Console.ReadLine() + ", chuc mot ngay tot lanh");
            //Console.Write("Vay ban bao nhieu tuoi : ");
            //Console.WriteLine("So tuoi cua ban la : " + Console.ReadLine());
            //Console.Write("Ban song o dau the : ");
            //Console.WriteLine("Dia chi cua ban : " + Console.ReadLine());
            //Console.ReadKey();

            //Bai 3
            string tuoi;
            int tuoick;
            Console.Write("Nhap tuoi cua ban : ");
            tuoi = Console.ReadLine();
            if (int.TryParse(tuoi, out tuoick) == false)
            {
                Console.WriteLine("Du lieu nhap sai !");
                Console.ReadKey();
                return;
            }
            else
            { 
                if (tuoick <= 16)
                    Console.WriteLine("Ban " + tuoick + " tuoi vi thanh nien");
                else if (tuoick >= 16 && tuoick < 18)
                    Console.WriteLine("Ban " + tuoick + " tuoi truong thanh");
                else
                {
                    if (tuoick >= 18)
                        Console.WriteLine("Ban " + tuoick + " tuoi, gia roi di kiem nguoi yeu di");
                }
            }       
            Console.ReadKey();

        }
    }
}
