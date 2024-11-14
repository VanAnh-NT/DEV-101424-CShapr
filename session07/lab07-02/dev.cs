using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_02
{
    internal class dev
    {
    }
}

namespace Business
{
    //lop nha o
    public class House
    { 
        public string HouseNo { get; set; }
        public decimal Price { get; set; }
    }

    //tạo namespace con đại lý lồng bên trong namespace kinh doanh 
    namespace Dealership
    {
        //tao lop xe
        public class Car
        { 
            public string CarNo { get; set; }
            public decimal Price { get; set; } 
        }
    }
}

