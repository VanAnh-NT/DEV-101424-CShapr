using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_03
{
    /// <summary>
    /// Lop sinh vien 
    /// </summary>
    internal class Student
    {
        //Khai bao mang mot chieu - ten 
        public string[] names;
        //Khai bao mang 2 chieu - diem 
        public double[,] marks;
        //Phương thức khởi tạo 
        public Student( int n,  int m)
        {
            names = new string[n];
            marks = new double[n,m];
        }
        //chỉ mục đơn 
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }

        }

        //chi muc kep 
        public double this[int i, int j]
        {
            get { return marks[i, j]; }
            set { marks[i, j] = value; }
        }
    }
}
