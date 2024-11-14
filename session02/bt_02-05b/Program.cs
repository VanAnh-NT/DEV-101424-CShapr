namespace bt_02_05b
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình in ra tam giác vuông ngược bằng ký  hiệu $
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so canh da muon in ra: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                for (int j = n; j >= i; j--)
                {
                    Console.Write('$');
                }
                Console.WriteLine();
            }
        }
    }
}
