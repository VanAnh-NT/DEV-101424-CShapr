using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_01
{
    internal class SavingAccount : Account 
    {
        private double rate;

        //constructor với hai tham số đầu vào
        public SavingAccount(double initialize, double rate) : base(initialize) { this.rate = rate; }
        //phương thức lấy tiền lãi 
        public double GetInterest() { return Balance * rate; }
        
    }
}
