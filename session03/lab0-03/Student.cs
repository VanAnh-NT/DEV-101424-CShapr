using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0_03
{
    internal class Student
    {
        //tạo các thuộc tính tự động 
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        //Định nghĩa phương thức Display, phương thức hiện thị 
        public void Display()
        {
            System.Console.WriteLine("Định danh học sinh: " + Id);
            System.Console.WriteLine("Tên của học sinh: " + Name);
            System.Console.WriteLine("Tuổi của học sinh: " + Age);
            System.Console.WriteLine("----------------------------------");
        
        }
    }
}
