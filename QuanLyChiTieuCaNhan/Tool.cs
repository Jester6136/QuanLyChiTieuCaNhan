using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QuanLyChiTieuCaNhan
{
    public struct ThuNhap
    {
        public int NgayIDThu;
        public int Luong;
        public int TienThuong;
        public string ChuThich;
    }
    public struct ChiTieu
    {
        public int NgayIDChi;
        public int Chitieu;
        public int Huongthu;
        public string ChuThich;
    }
    public class Tool
    {
        public string Tex1 = "ThuNhap.txt", Tex2 = "ChiTieu.txt";
        public ThuNhap[] Thu=new ThuNhap[10001];
        public ChiTieu[] Chi= new ChiTieu[10001];
        public int indexThu =-1;
        public int indexChi = -1;
        public int ChonMenu()
        {
            int tra;
            Console.WriteLine("------------------MENU--------------------");
            Console.WriteLine("1. Nhap du lieu");
            Console.WriteLine("2. Hien thi");
            Console.WriteLine("3.Tim kiem");
            Console.WriteLine("4.Sua");
            Console.WriteLine("5.Xoa"); 
            Console.WriteLine("6.Thong ke");
            Console.WriteLine("7.Thoat");
            Console.Write("Ban hay nhap mot moc tu (1-->7): ");
            tra = int.Parse(Console.ReadLine());
            return tra;
        }
        public void NhapThu()
        {
            StreamReader sr = new StreamReader(Tex1);
            StringBuilder sb = new StringBuilder();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                sb.AppendLine(s);
                
            }
            sr.Close();
            string a = "y";
            while (a == "y")
            {
                ThuNhap t = new ThuNhap();
                Console.Write("NgayID ThuNhap: ");
                t.NgayIDThu = int.Parse(Console.ReadLine());

                Console.Write("Tien Luong : ");
                t.Luong = int.Parse(Console.ReadLine());

                Console.Write("Tien Thuong: ");
                t.TienThuong = int.Parse(Console.ReadLine()); ;

                Console.Write("Chu thich : ");
                t.ChuThich = Console.ReadLine();

                sb.AppendLine(t.NgayIDThu + "|" + t.Luong + "|" + t.TienThuong + "|" + t.ChuThich);

                indexThu+=1;
                Thu[indexThu] = t;
                Console.Write("Ban co muon nhap tiep khong (y/n)? ");
                a = Console.ReadLine();
            }
            StreamWriter sw = new StreamWriter(Tex1);
            sw.Write(sb.ToString());
            sw.Close();
            Console.WriteLine("Ban da ghi thanh cong!!");
        }
        public void NhapChi()
        {
            StreamReader sr = new StreamReader(Tex2);
            StringBuilder sb = new StringBuilder();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                sb.AppendLine(s);

            }
            sr.Close();
            string a = "y";
            while (a == "y")
            {
                ChiTieu c = new ChiTieu();
                Console.Write("NgayID ChiTieu: ");
                c.NgayIDChi = int.Parse(Console.ReadLine());

                Console.Write("Chi Tieu : ");
                c.Chitieu = int.Parse(Console.ReadLine());

                Console.Write("Tien huong thu : ");
                c.Huongthu = int.Parse(Console.ReadLine());

                Console.Write("Chu thich : ");
                c.ChuThich = Console.ReadLine();

                sb.AppendLine(c.NgayIDChi + "|" + c.Chitieu + "|" + c.Huongthu + "|" + c.ChuThich);

                indexChi++;
                Chi[indexThu] = c;
                Console.Write("Ban co muon nhap tiep khong (y/n)? ");
                a = Console.ReadLine();
            }
            StreamWriter sw = new StreamWriter(Tex2);
            sw.Write(sb.ToString());
            sw.Close();
            Console.WriteLine("Ban da ghi thanh cong!!");
        }
        public int MenuNhap()
        {
            int tra;
            Console.WriteLine("1.Nhap khoan thu nhap");
            Console.WriteLine("2.Nhap khoan chi tieu");
            tra = int.Parse(Console.ReadLine());
            return tra;
        }
        public void Nhap()
        {
            int check = MenuNhap();
            if (check == 1)
                NhapThu();
            else if (check == 2)
                NhapChi();
            else
                Console.WriteLine("Sai cu phap");
        }
        public void Xuat()
        {

        }
        public void TimKiem()
        {

        }
        public void Sua()
        {

        }
        public void Xoa()
        {

        }
        public void ThongKe()
        {

        }

    }
}
