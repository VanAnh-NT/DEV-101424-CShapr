namespace bt_02_05a
{
    internal class Program
    {
        /// <summary>
        /// Viết chương tình in sao 
        /// *
        /// **
        /// ***
        /// ****
        /// *****
        /// ******
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int n;
            Console.Write("Nhap vao so muon in ra * tam giac vuong: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
