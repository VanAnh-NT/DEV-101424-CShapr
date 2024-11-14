using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_01
{
    abstract class Account
    {
        //Lớp account lưu thông tin về tài khoản (Balance - số tiền trong tài khoản)
        protected double Balance;

        //constructor với đầu vào là initialize (số tiền ban đầu)
        public Account(double initialize)
        {
            Balance = initialize;
        }


        #region các phương thức gửi, rút, trả về số tiền trong tài khoản  
        //Phương thức gửi tiền cho phép ghi đè bằng phương thức vitrual 
        public virtual void Deposit(double money)
        {
            if (money <= 0)
            {
                Console.WriteLine("Tiền gửi phải lớn hơn 0");
                return;
            }
            Balance += money;
            Console.WriteLine($"Đã gửi {money}. Số dư hiện tại là: {Balance}");
        }

        //phương thức rút tiền cho phép ghi đè 
        public virtual void Withdraw(double money) { 
            if(money <= 0)
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0 đồng");
                return;
            }
            if (money > Balance)
            {
                Console.WriteLine("Số dư không đủ để rút");
                return;
            }
            Balance -= money;
            Console.WriteLine($"Đã rút: {money}. Số dư hiện tại là: {Balance}");
        }

        //Phương thức trả về số tiền trong tài khoản 
        public double GetBalance()
        { 
            return Balance;
        }
        #endregion 

    }
}
