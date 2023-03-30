using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_dangnhapuser
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass,pass2, input, inputuser, inputpass;
            Console.Write("Ban co muon dang ky tai khoan (Y/N):");
            input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                do
                {
                    Console.Write("Ten dang nhap :"); user = Console.ReadLine();
                    Console.Write("Mat khau :"); pass = Console.ReadLine();
                    Console.Write("Nhap lai mat khau :"); pass2 = Console.ReadLine(); Console.WriteLine();
                }
                while (pass != pass2);

                Console.WriteLine("Chuc mung ban da tao tai khoan thanh cong!!!");
                Console.Write("Ban co muon dang nhap (Y/N):");
                string input2 = Console.ReadLine();
                if (input2 == "Y" || input2 == "y")
                {
                    do
                    {
                        Console.Write("ten dang nhap :");  inputuser = Console.ReadLine();
                        Console.Write("mat khau :"); inputpass = Console.ReadLine();
                        if(inputuser!=user || inputpass!=pass)
                        {
                            Console.WriteLine("Ban da nhap sai tai khoan hoac mat khau");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    while (inputuser != user || inputpass != pass);
                    Console.WriteLine("Dang nhap thanh cong !");
                }

            }
            else
                return;
            Console.ReadKey();
        }
    }
}
