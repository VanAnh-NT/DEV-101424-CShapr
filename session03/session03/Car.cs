using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_01
{
    internal class Car
{
    //Khai báo các trường với phạm vi public 
    public string make;
    public string model;
    public string color;
    public int year;


    //Định nghĩa phương thức start 
    public void Start()
    {
        System.Console.WriteLine(model + ": Khởi động");
    }


    //Định nghĩa phương thức stop 
    public void Stop() 
    { 
        System.Console.WriteLine(model + ": Dừng lại");
    }

}
}
