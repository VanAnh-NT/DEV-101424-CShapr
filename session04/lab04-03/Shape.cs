using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_03
{
    abstract class Shape
    {
        protected float radius, length, width;

        //Khai báo phương thức trừu tượng 
        public abstract float Area();//tính diện tích
        public abstract float Cỉcumference();//tinh chu vi 

    }
}