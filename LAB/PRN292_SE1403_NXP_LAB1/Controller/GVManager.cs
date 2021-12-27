using PRN292_SE1403_NXP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRN292_SE1403_NXP.Controller
{
    class GVManager
    {
        List<GiangVien> list = new List<GiangVien>();
        public void menu()
        {
            int choice = 0;
            GiangVien gv = new GiangVien();
            Console.WriteLine("========Giang Vien Manager=======");
            do
            {
                Console.WriteLine("1. Them GV");
                Console.WriteLine("2. Show GV");
                Console.WriteLine("0. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    
                    case 1:
                        add();
                        break;
                    case 2:
                        show();
                        break;
                    case 0:
                        Console.WriteLine("Exit. Thank you");
                        break;
                    default:
                        Console.WriteLine("Please choice 0-2");
                        break;
                }
            } while (choice != 0);
        }

        public void add()
        {
            Console.WriteLine("Nhap so luong GV: ");
            int sl = Convert.ToInt32(Console.ReadLine());           
            GiangVien gv = new GiangVien();
            for(int i = 0; i < sl; i++)
            {
                gv.input();
                list.Add(new GiangVien(gv.id, gv.name, gv.namSinh, gv.trinhDo, gv.heSoLuong));
            }
        }

        public void show()
        {
            list.ForEach(x => x.output());
        }
    }
}
