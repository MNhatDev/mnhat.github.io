using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoSanhHaiSo_A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrA, StrB;
            int A,B;
            Console.Write("Nhap so A : "); StrA = Console.ReadLine();
            Console.Write("Nhap so B : "); StrB = Console.ReadLine();
            if (((int.TryParse(StrA, out A))==false) || ((int.TryParse(StrB, out B))==false))
            {
                Console.WriteLine("Du lieu nhap sai");
            }
            else
                // BAI TAP VIET BANG CAU LENH IF
                //if (A > B)
                //{
                //    Console.WriteLine("So A lon hon B");
                //}
                //else if (A < B)
                //{
                //    Console.WriteLine("So A nho hon B");
                //}
                //else
                //{
                //    Console.WriteLine("So A bang so B");
                //}

                //BAI TAP VIET BANG CAU LENH SWITCH CASE
                switch (A > B)
                {
                    case true:
                        Console.WriteLine("{0} lon hon {1}", A, B);
                        break;
                    case false:
                        switch (A < B)
                        {
                            case true:
                                Console.WriteLine("{0} nho hon {1}", A, B);
                                break;
                            default:
                                Console.WriteLine("{0} bang {1}", A, B);
                                break;
                        }
                        break;
               }
                    
            Console.ReadKey();
        }
    }
}
