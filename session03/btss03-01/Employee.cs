using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btss03_01
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public static double basicSalary { get; set; }

        public double GetIncome() {
            return salaryLevel * basicSalary;
        }

        public void Display() { 
            System.Console.WriteLine("Dinh danh nhan vien: " + Id);
            System.Console.WriteLine("Ten nhan vien: " + Name);
            System.Console.WriteLine("Nam sinh nhan vien: " + yearOfBirth);
            System.Console.WriteLine($"Luong co ban cua nhan vien: {basicSalary:N0}");
            System.Console.WriteLine($"Thu nhap cua nhan vien: {GetIncome():N0}");
        }
    }
}
