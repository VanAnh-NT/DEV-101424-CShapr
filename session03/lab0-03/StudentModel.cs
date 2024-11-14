using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0_03
{
    internal class StudentModel
    {
        //Khai báo danh sách tập hợp chữa các sinh viên 
        List<Student> liststudent;

        //Phương thức khởi tạo 
        public StudentModel() {
            //Khởi tạo danh sách sinh viên 
            this.liststudent = new List<Student> {
            new Student(){Id=1, Name="Dương", Age=25},
            new Student(){Id=2, Name="Uyển", Age=16},
            new Student(){Id=3, Name="Hạnh", Age=26},
            new Student(){Id=4, Name="Phương", Age=19},
            new Student(){Id=5, Name="Mỹ", Age=20},
            };
        }
        #region các phương thức overloading 
        
        //Phương thức trả về danh sách sinh viên 
        public List<Student> GetStudent()
            { return this.liststudent; }

        //Phương thức trả về sinh viên theo Id 
        public Student GetStudent(int id) {
            Student st = null;
            foreach (var item in liststudent)
            {
                if (item.Id == id) { st = item;}
            }
            return st;
        }

        //Phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in liststudent)
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
 