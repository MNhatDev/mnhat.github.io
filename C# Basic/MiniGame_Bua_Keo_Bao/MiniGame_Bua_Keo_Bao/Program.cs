using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame_Bua_Keo_Bao
{
    class Program
    {
        static void Main(string[] args)
        {
            String hand_pc, hand, name;
            hand_pc = "Bua";
            Random ran = new Random();
            int so_random = ran.Next(1, 3);
            Console.WriteLine("**********************************");
            Console.WriteLine("*                                *");
            Console.WriteLine("*     Mini game BUA_KEO_BAO      *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");
            Console.Write("Player name : ");
            name = Console.ReadLine();
            Console.Write("{0} chon Bua, Keo hoac Bao : ",name);
            hand = Console.ReadLine();
            Console.WriteLine();
            switch (so_random + 0)
            {
                case 1:
                    hand_pc = "Bua";
                    break;
                case 2:
                    hand_pc = "Keo";
                    break;
                case 3:
                    hand_pc = "Bao";
                    break;
            }
            Console.WriteLine("MYCOM : {0}",hand_pc);
            if ((hand_pc == "Bua") && (hand == "bao"))
            {
                Console.WriteLine("KQ = Bao an Bua BAN THANG !");
            }
            else if((hand_pc =="Bua") && (hand =="keo"))
            {
                Console.WriteLine("KQ = Bua an Keo ban thua !");
            }
            else
            {
                if ((hand_pc == "Keo") && (hand == "bua"))
                {
                    Console.WriteLine("KQ = Keo thua bua BAN THANG !");
                }
                else if ((hand_pc == "Keo") && (hand == "bao"))
                {
                    Console.WriteLine("KQ = Keo an bao ban thua !");
                }
                else
                    if((hand_pc =="Bao") && (hand == "bua"))
                    {
                        Console.WriteLine("KQ = Bao an bua ban thua");
                    }
                    else if((hand_pc=="Bao") && (hand =="keo"))
                    {
                        Console.WriteLine("KQ = Bao thua keo BAN THANG !");
                    }
                    else
                        Console.WriteLine("KQ = HOA");
            }
            Console.ReadKey();
        }
    }
}
