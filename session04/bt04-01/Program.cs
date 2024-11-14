namespace bt04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Account saving = new SavingAccount(1000, 0.05);
            //nap tien 
            saving.Deposit(500);
            Console.WriteLine("Số dư: " + saving.GetBalance());
            //rut tien
            saving.Withdraw(1000);
            saving.GetBalance();
            //xem tien lai 
            SavingAccount savingAcc = (SavingAccount)saving;


            //Tính thêm phí sau những lần nạp và rút tiền 
            Account fee = new CheckAccount(1000, 0.05);
            fee .Deposit(500);
            fee.GetBalance();
            fee .Withdraw(1000);
            fee.GetBalance();
        }
    }
}
