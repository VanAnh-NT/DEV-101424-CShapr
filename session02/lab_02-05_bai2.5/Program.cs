namespace lab_02_05_bai2_5
{
    internal class Program
    {
        /// <summary>
        /// Nhập xuất các cấu trúc điều khiển 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo biến tổng 
            int sum = 0;
            int i;
            //duyệt từ 1 - 100
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 != 0) sum += i;
            }
            //in ra kết quả 
            Console.WriteLine("Tổng các số chẵn không chia hết cho 3 từ 1 - 100 là {0}", sum);
        }
    }
}