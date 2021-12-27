using System;
using System.Collections.Generic;
using System.Text;

namespace PRN292_SE1403_NXP.Model
{
    class GiangVien
    {
        public GiangVien()
        {
        }

        public GiangVien(string id, string name, DateTime namSinh, string trinhDo, double heSoLuong)
        {
            this.id = id;
            this.name = name;
            this.namSinh = namSinh;
            this.trinhDo = trinhDo;
            this.heSoLuong = heSoLuong;
        }

        public String id { get; set; }
        public String name { get; set; }
        public DateTime namSinh { get; set; }
        public String trinhDo { get; set; }
        public Double heSoLuong { get; set; }

        

        public void input()
        {
            Console.WriteLine("ID: ");
            while (true)
            {
                String temp = Console.ReadLine();
                if()
            }
            id = Console.ReadLine();
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Nam sinh: ");           
            while (true)
            {
                DateTime tempTime = Convert.ToDateTime(Console.ReadLine());
                if(2020 - tempTime.Year >= 23)
                {
                    namSinh = tempTime;
                    break;
                }
                else
                {
                    Console.Write("Phai lon hon 23 tuoi moi duoc nhap hoc. Nhap lai: ");
                }
            }
            
            Console.WriteLine("Trinh do: ");
            int choice = 0;
            do
            {
                Console.WriteLine("1. Dai hoc");
                Console.WriteLine("2. Thac sy");
                Console.WriteLine("3. Tien si");
                Console.WriteLine("4. Nghien cuu sinh");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        trinhDo = "Dai hoc";
                        break;
                    case 2:
                        trinhDo = "Thac sy";
                        break;
                    case 3:
                        trinhDo = "Tien si";
                        break;
                    case 4:
                        trinhDo = "Nghien cuu sinh";
                        break;
                }
            } while (choice < 1 && choice > 4);
            Console.WriteLine("He so luong: " );
            while (true)
            {
                Double temp = Convert.ToDouble(Console.ReadLine());
                if(temp > 0 && temp < 5)
                {
                    heSoLuong = temp;
                    break;
                }
                else
                {
                    Console.Write("Luong phai lon hon 0 va be hon 5");
                }
            }
            
        }

        public void output()
        {
            Console.WriteLine("ID\tName\tNamSinh\tTrinhdo\tHesoLuong");
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{this.id}\t{this.name}\t{this.namSinh.Year}\t{this.trinhDo}\t{this.heSoLuong}";
        }
    }
}
