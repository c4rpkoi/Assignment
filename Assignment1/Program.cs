using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static string Menu()
        {
            Console.WriteLine("---------------Menu--------------");
            Console.WriteLine("1. Nhập ");
            Console.WriteLine("2. Xuất ");
            Console.WriteLine("3. Sửa");
            Console.WriteLine("4. Xóa ");
            Console.WriteLine("5. Sắp xếp");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("Mới bạn nhập các lựa chọn");
            string luachon = Console.ReadLine();
            return luachon;
        }
        static void MenuLap()
        {
            VnVaccineService sv = new VnVaccineService();
            do
            {
                switch (Menu())
                {
                    case "1":
                        sv.Them();
                        Console.Clear();
                        break;
                    case "2": sv.InDs(); break;
                    case "3": sv.Sua(); break;
                    case "4": sv.Xoa(); break;
                    case "5": sv.SapXep(); break;
                    case "0":
                        System.Environment.Exit(18361823); break;
                    default: Console.WriteLine("Bạn nhập sai rồi hãy nhập lại đê"); break;
                }
            } while (true);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MenuLap();
        }
    }
}
