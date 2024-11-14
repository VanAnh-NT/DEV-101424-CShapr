using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_03
{
    internal class Circle:Shape 
    {
        //Phương thức nhập liệu 
        public void InputData()
        {
            Console.Write("Nhập vào bán kính: ");
            radius = float.Parse(Console.ReadLine());
        }

        //ghi đè phương thức tính diện tích 
        public override float Area()
        {
            return 3.14F * radius * radius;
        }

        //ghi đè phương thức tính chu vi 
        public override float Cỉcumference()
        {
            return 2 * 3.14F * radius;
        }
    }
}
