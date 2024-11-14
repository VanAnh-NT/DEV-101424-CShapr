namespace debug
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 0;
            try
            {
                int result = Divide(a, b);
                Console.WriteLine("Kết quả: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Lỗi: Không thể chia cho số 0.");
                Console.WriteLine("Thông tin lỗi: " + ex.Message);
                Console.WriteLine("Stack trace: " + ex.StackTrace);
            }
        }

        static int Divide(int x, int y)
        {
            return x / y;  // Lỗi chia cho 0 sẽ xảy ra ở đây
        }
    }
}
