using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true) {
                students.Add(QLHS.Nhap1HS());
                Console.WriteLine("ban co muon nhap tiep khong (1(co)/(any)(khong)");
                var input = Console.ReadLine();
                if (input != "1") break;

            }
            Console.WriteLine("Danh sach hoc sinh vua nhap la: ");
            students.ForEach(i => QLHS.In1HS(i));
            QLHS.Menu();

            do
            {
                Console.WriteLine("Moi ban chon hanh dong muon thuc hien");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        QLHS.InHS15den18(students);
                        break;
                    case "2":
                        QLHS.InHSTenBatDauBangA(students);
                        break;
                    case "3":
                        QLHS.InTongSoTuoi(students);
                        break;
                    case "4":
                        QLHS.InHSLonNhat(students);
                        break;
                    case "5":
                        QLHS.SapXepTheoTuoi(students);
                        break;
                    case "7":
                        QLHS.Them20SV(students);
                        Console.WriteLine("Danh sach hoc sinh sau khi them 20 sinh vien la: ");
                        students.ForEach(i => QLHS.In1HS(i));
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai");
                        break;
                }
                QLHS.Menu();
            } while (true);

        }
    } 
}
