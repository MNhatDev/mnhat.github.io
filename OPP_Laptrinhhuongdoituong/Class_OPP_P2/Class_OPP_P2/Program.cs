using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_OPP_P2
{
    class SinhVien
    {
        private double DTB;
        private string MASV;
        private string HoTen;
        private double DiemToan;

        public double DiemToan1
        {
            get { return DiemToan; }
            set { DiemToan = value; }
        }
        private double diemly;
        private double diemvan; //Ctrl + R + E      ; Ctrl + R + .

        public double Diemvan
        {
            get { return diemvan; }
            set { diemvan = value; }
        }
        public double DiemLy
        {
            get {return diemly;}
            set
            {
                if (value <= 10 || value >= 0)
                {
                    diemly = value;
                }
            }
        }
        public void InThongTinDiemTB()
        {
            DTB = (DiemToan + diemvan + diemly) / 3;
            Console.WriteLine("Sinh Vien " + HoTen + " Co diem TB la : " + DTB);
        }
        public void HocLucSinhVien()
        {
            if (DTB <= 4)
                Console.WriteLine("Hoc luc yeu");
            else if (DTB <= 6.5)
                Console.WriteLine("Hoc luc trung binh");
            else if (DTB <= 8)
                Console.WriteLine("Hoc luc kha");
            else if (DTB <= 9)
                Console.WriteLine("Hoc luc gioi");
            else
                Console.WriteLine("Hoc luc xuat xac cmnr");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            SV1.DiemToan1 = 10;
            SV1.DiemLy = 8;
            SV1.Diemvan = 7;
            SV1.InThongTinDiemTB();
            SV1.HocLucSinhVien();3
            Console.ReadKey();
        }
    }
}
