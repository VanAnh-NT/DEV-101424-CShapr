using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_03
{
    internal class Rectangle : Shape 
    {
        //Phương thức nhập liệu 
        public void InputData()
        {
            Console.Write("Nhập chiều dài: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            width = int.Parse(Console.ReadLine());
        }

        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return length * width;
        }

        //ghi đè phương thức tinh chu vi 
        public override float Cỉcumference()
        {
            return 2 * length * width;
        }
    }
}
