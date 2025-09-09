using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class QLHS
    {
        public static void Menu()
        {
            Console.WriteLine("1. In cac hoc sinh co tuoi tu 15 den 18");
            Console.WriteLine("2. In cac hoc sih co ten bat dau bang chu A");
            Console.WriteLine("3. In ong so tuoi cua tat ca hoc sinh trong danh sach");
            Console.WriteLine("4. In hoc sinh co tuoi lon nhat");
            Console.WriteLine("5. Sap xep danh sach hoc sinh theo tuoi tang dan");
            Console.WriteLine("6. In danh sach hoc sinh");
            Console.WriteLine("7. them 20 sinh vien ngau nhien vao danh sach");
            Console.WriteLine("0. Thoat");
        }
        public static Student Nhap1HS()
        {
            Student student = new Student();
            Console.Write("Nhap Id: ");
            student.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten: ");
            student.Name = Console.ReadLine();
            Console.Write("Nhap Tuoi: ");
            student.Age = int.Parse(Console.ReadLine());
            return student;
        }
        public static void In1HS(Student student)
        {
            Console.WriteLine(student.Id + "---" + student.Name + "---" + student.Age);
        }
        public static void InHS15den18(List<Student> students)
        {
            students.Where(s => s.Age >= 15 && s.Age <= 18).ToList().ForEach(s => In1HS(s));
        }
        public static void InHSTenBatDauBangA(List<Student> students)
        {
            students.Where(s => s.Name.StartsWith("A")).ToList().ForEach(s => In1HS(s));
        }
        public static void InTongSoTuoi(List<Student> students)
        {
            Console.WriteLine("Tong so tuoi cua tat ca hoc sinh la: " + students.Sum(s => s.Age));
        }
        public static void InHSLonNhat(List<Student> students)
        {
            int maxAge = students.Max(studient => studient.Age);
            students.Where(s => s.Age == maxAge).ToList().ForEach(s => In1HS(s));
        }
        public static void SapXepTheoTuoi(List<Student> students)
        {
            students.OrderBy(s => s.Age).ToList().ForEach(s => In1HS(s));
        }
        public static void Them20SV(List<Student> students)
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Student student = new Student();
                student.Id = i + 1;
                student.Name =(char) rand.Next('A','D'+1) + "Student" + (i + 1);
                student.Age = rand.Next(10, 21); // Tuoi ngau nhien tu 10 den 20
                students.Add(student);
            }
        }



    }
}// End of ConsoleApp2/QLHS.cs