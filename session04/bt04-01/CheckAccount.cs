using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_01
{
    internal class CheckAccount : Account 
    {
        private double FeeTransfer;

        public CheckAccount(double initialize, double FeeTransfer)
            : base(initialize) { 
            this.FeeTransfer = FeeTransfer;
        }
        #region ghi đè hai phương thức của lớp Account (gửi và rút tiền), khi gọi các phương thức thành công thì sẽ mất phí 
        public override void Deposit(double money)
        {
            base.Deposit(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Phí giao dịch {FeeTransfer} đã được trừ. Số dư còn lại là: {Balance}");

        }
        public override void Withdraw (double money)
        {
            base.Withdraw(money);
            Balance -= FeeTransfer;
            Console.WriteLine($"Phí giao dịch {FeeTransfer} đã được trừ. Số dư còn lại là: {Balance}");

        }
        #endregion
    }
}
