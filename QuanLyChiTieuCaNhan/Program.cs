using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QuanLyChiTieuCaNhan
{
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Tool Tool = new Tool();
            Console.WriteLine(Tool.indexThu);
            Console.Clear();
            do
            {
                switch (Tool.ChonMenu())
                {
                    case 1: Tool.Nhap(); break;
                    case 2:Tool.Xuat();break;
                    case 3:Tool.TimKiem();break;
                    case 4:Tool.Sua();break;
                    case 5:Tool.Xoa();break;
                    case 6:Tool.ThongKe();break;
                    case 7: Environment.Exit(0); break;
                }
                Console.Clear();
            }
            while (true);
        }
    }
}
