namespace bt_02_05c
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình in ra tam giác cân 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int height;
            Console.Write("Nhap chieu cao bang so * muon in tam giac: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++) {
                // In khoảng trắng
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                // In dấu *
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
