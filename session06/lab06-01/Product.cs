using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_01
{
    internal class Product
    {
        //khai báo trường 
        string name;
        double cost;
        int onhand;

        //constructor 
        public Product(string n, double c, int h) { 
        name = n;
        cost = c;
        onhand = h;}

        //ghi đè phương thức ToString
        public override string ToString()
        {
            
            return String.Format("{0, -10}Cost: {1,3:C}   On hand: {2}", name, cost, onhand);
        }
    }
}
