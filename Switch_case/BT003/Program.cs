using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT003
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNam="",can ="",chi="";
            int nam;
            Console.WriteLine("**********************************");
            Console.WriteLine("*                                *");
            Console.WriteLine("*        Tinh nam am lich        *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.Write("Nhap mot nam(year) bat ki : ");
            //strNam = Console.ReadLine();
            //if (int.TryParse(strNam, out nam)==false)
            //{
            //    Console.WriteLine("Du lieu nhap sai !");
            //    Console.ReadKey();
            //    return;
            //}
            nam = Int32.Parse(Console.ReadLine());
            switch (nam%10)
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can ="Tan";
                    break;
                case 2:
                    can ="Nham";
                    break;
                case 3:
                    can ="Quy";
                    break;
                case 4:
                    can ="Giap";
                    break;
                case 5:
                    can ="At";
                    break;
                case 6:
                    can = "Binh";
                    break;
                case 7:
                    can = "Dinh";
                    break;
                case 8:
                    can = "Mau";
                    break;
                case 9:
                    can = "Ky";
                    break;

            }
            switch (nam % 12)
            {
                case 0:
                    chi = "Than";
                    break;
                case 1:
                    chi = "Dau";
                    break;
                case 2:
                    chi = "Tuat";
                    break;
                case 3:
                    chi = "Hoi";
                    break;
                case 4:
                    chi = "Ty";
                    break;
                case 5:
                    chi = "Suu";
                    break;
                case 6:
                    chi = "Dan";
                    break;
                case 7:
                    chi = "Meo";
                    break;
                case 8:
                    chi = "Thin";
                    break;
                case 9:
                    chi = "Ty";
                    break;
                case 10:
                    chi = "Ngo";
                    break;
                case 11:
                    chi = "Mui";
                    break;

            }
            Console.WriteLine("Nam {0} nay la nam  : {1} {2} ",nam,can,chi);



            Console.ReadKey();

        }
    }
}
