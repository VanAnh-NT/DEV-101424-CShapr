using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_4
{   
    //định nghĩa lớp nhân viên thực thi từ giao diện IPerson 
    internal class Staff : IPerson
    {
        //thực thi các phương thức các giao diện 
        public void Insert(object obj)
        {
            Console.WriteLine("Đã lưu đối tượng: " + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Đã xóa đối tượng: " + obj);
        }
        public void Update(object obj)
        {
            Console.WriteLine("Đã cập nhật đối tượng: " + obj);
        }
        public void Display(object obj)
        {
            Console.WriteLine("Thông tin đối tượng: " + obj);
        }
    }
}
