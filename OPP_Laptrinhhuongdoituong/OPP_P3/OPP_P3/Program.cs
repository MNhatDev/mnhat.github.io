using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //them thu vien

namespace OPP_P3
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        public Student() // constructer mac dinh
        {
            SID = 1;
            TenSV = "Duong Minh Nhat";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public Student(Student stu) //constructor sao chep
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        //constructor tham so
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        public int studentID
        {
            get { return SID; }//lay du lieu
            set { SID = value; }//Gan du lieu
        }
        public string Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public string Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void show()
        {
            Console.WriteLine("MSSV:{0}", this.SID);
            Console.WriteLine("Ten SV:{0}", this.TenSV);
            Console.WriteLine("Khoa :{0}", this.Khoa);
            Console.WriteLine("Diem TB : {0}", this.DiemTB);
        }
    }





    //class Nhap_Xuat //Bai tap 2
    //{
    //    private int n;
    //    private Student[] DSSV;
    //    public void nhapsoluong()
    //    {
    //        Console.Write("Nhap so luong SV : ");
    //        n = int.Parse(Console.ReadLine());
    //        DSSV = new Student[n];

    //    }
    //    public void NhapDS()
    //    {
    //        Console.WriteLine("\n ====NHAP DS SINH VIEN====");
    //        for (int i = 0; i < n; i++)
    //        {
    //            DSSV[i] = new Student();
    //            Console.WriteLine();
    //            Console.Write("Nhap MaSV {0} : ", i + 1);
    //            DSSV[i].studentID = int.Parse(Console.ReadLine());
    //            Console.Write("Ho ten SV: ");
    //            DSSV[i].Name = Console.ReadLine();
    //            Console.Write("Nhap khoa : ");
    //            DSSV[i].Faculty = Console.ReadLine();
    //            Console.Write("Nhap diem TB : ");
    //            DSSV[i].Mark = float.Parse(Console.ReadLine());
    //        }
    //    }
    //    public void XuatDS()
    //    {
    //        Console.WriteLine("\n =====XUAT DS SINH VIEN=====");
    //        foreach (Student sv in DSSV)
    //            sv.show();
    //        Console.ReadLine();
    //    }






    //}
    // Bai tap 3
    class people
    {
        private ArrayList listStudent = new ArrayList();
        private int x;
        public void Xuat_Soluong()
        {
            listStudent = new ArrayList();
            int a = listStudent.Count;
            Console.WriteLine("Danh sach hoc sinh la " + a);
        }
        public void Nhap_SV()
        {
            int a;
            string b, c;
            float d;
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
                int i =0;
                listStudent = new ArrayList();
                Console.WriteLine();
                Console.Write("Nhap MaSV {0} : ", i + 1);
                a = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV: ");
                b = Console.ReadLine();
                Console.Write("Nhap khoa : ");
                c = Console.ReadLine();
                Console.Write("Nhap diem TB : ");
                d = float.Parse(Console.ReadLine());
                listStudent.Add(new Student(a, b, c, d));
            
        }
        public void Show_SV()
        {
            foreach (Student sv in listStudent)
                sv.show();
            Console.ReadLine();
        }
        public void iff()
        {
            people I = new people();
            Console.WriteLine("1. nhap thong tin hoc sinh");
            Console.WriteLine("2. xuat danh sach hoc sinh");
            Console.WriteLine("3. xuat so luong hoc sinh");
            x = int.Parse(Console.ReadLine());
            iff2();
        }
        public void iff2()
        {
            people I = new people();
            if (x == 1)
            {
                I.Nhap_SV();
                I.iff();

            }
            else if (x == 2)
            {
                I.Show_SV();
                I.iff();
            }
            else
            {
                I.Xuat_Soluong();
                I.iff();
            }
        }

        




    //{ 
    //private List<Student> ListStudent = null;
    //private int count;
    //public void SoluongSinhVien()
    //{
    //    count = 0;
    //    Console.Write("Nhap so luong SV : ");
    //    count = int.Parse(Console.ReadLine());
    //}
    //public void NhapSinhVien()
    //{
    //    Console.WriteLine("\n ====NHAP DS SINH VIEN====");
    //    int b = 0;
    //    Student sv = new Student();
    //    Console.Write("Nhap MaSV {0} : ", b = b + 1);
    //    sv.studentID = int.Parse(Console.ReadLine());
    //    Console.Write("Ho ten SV: ");
    //    sv.Name = Convert.ToString(Console.ReadLine());
    //    Console.Write("Nhap khoa : ");
    //    sv.Faculty = Convert.ToString(Console.ReadLine());
    //    Console.Write("Nhap diem TB : ");
    //    sv.Mark = float.Parse(Console.ReadLine());
    //    ListStudent.Add(sv);
    //}
    //public void ShowSV()
    //{







        //Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}", "ID", "Name", "Faculty", "Diem TB");
        //// hien thi danh sach sinh vien
        //if (ListStudent != null && ListStudent.Count > 0)
        //{
        //    foreach (Student sv in ListStudent)
        //    {
        //        Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5}", sv.studentID, sv.Name, sv.Faculty, sv.Mark);
        //    }
        //}
        //Console.WriteLine();
    //}
}
class Tester
    {
        static void Main()
        {
            people I = new people();
            I.iff2();
            
            

            Console.ReadKey();
            //Bai tap 3
            //people sv = new people();
            //sv.SoluongSinhVien();
            //sv.NhapSinhVien();
            //sv.ShowSV();
            //Console.ReadKey();


            //Bai tap 2
            //Nhap_Xuat nhapxuat = new Nhap_Xuat();
            //nhapxuat.nhapsoluong();
            //nhapxuat.NhapDS();
            //nhapxuat.XuatDS();



            //Bai tap1
            //Student[] DSSV;
            //int n;
            //Console.Write("Nhap so luong SV : ");
            //n = int.Parse(Console.ReadLine());
            //DSSV = new Student[n];
            //Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            //for (int i = 0; i < n; i++)
            //{
            //    DSSV[i] = new Student();
            //    Console.WriteLine();
            //    Console.Write("Nhap MaSV {0} : ", i + 1);
            //    DSSV[i].studentID = int.Parse(Console.ReadLine());
            //    Console.Write("Ho ten SV: ");
            //    DSSV[i].Name = Console.ReadLine();
            //    Console.Write("Nhap khoa : ");
            //    DSSV[i].Faculty = Console.ReadLine();
            //    Console.Write("Nhap diem TB : ");
            //    DSSV[i].Mark = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n =====XUAT DS SINH VIEN=====");
            //foreach (Student sv in DSSV)
            //    sv.show();
            //Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
