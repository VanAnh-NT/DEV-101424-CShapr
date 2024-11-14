namespace bt_02_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.Write("Nhap vao so tien gui: ");
            double principal = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Nhap vao lai suat tính theo năm                                                : ");
            double yearlyInterestRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao so thang gui tien: ");
            double depositMonth = Convert.ToDouble(Console.ReadLine());

            //Tính lãi suất tháng 
            double monthlyInterestRate = (yearlyInterestRate/12)/ 100;
            //Biến để lưu tổng số tiền lãi cuối kỳ 
            double totalInterest = 0;

            //Biến để lưu tổng số tiền lãi cuối kỳ 
            for (int i = 1; i <= depositMonth; i++)
            {
                //Tính tiên lãi tháng hiện tại 
                double interestForTheMonth = principal * monthlyInterestRate;
                //Cộng tiền lãi vào tiền gốc 
                double oldPrincipal = principal; //lưu lại tiền gốc ban đầu 
                principal += interestForTheMonth;
                //Tích lũy tiền lãi 
                totalInterest += interestForTheMonth;

                Console.WriteLine($"Tháng {i}: Tiền gốc = {oldPrincipal:N0}, Tiền lãi = {interestForTheMonth:N0} VND, Số dư hiện tại = {principal:N0} VND");
            }
            Console.WriteLine($"\nPhần trăm sẽ nhận được là trên một năm là: {monthlyInterestRate:P2}");
            Console.WriteLine($"Số dư cuối kỳ: {principal:N2} VND");
            Console.WriteLine($"Tổng tiền lãi cuối kỳ: {totalInterest:N0} VND");
        }
    }
}
