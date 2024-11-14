namespace bt_02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Duyệt qua từng dòng từ 1 đến n
            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng để căn giữa các dòng
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");  // In hai khoảng trắng cho mỗi đơn vị khoảng trắng
                }

                // In dãy số tăng dần từ i
                int value = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(value % 10 + " ");  // In giá trị tăng dần và thêm khoảng trắng giữa các số
                    value++;
                }

                // In dãy số giảm dần từ giá trị cao nhất - 2
                value -= 2;
                for (int j = 1; j < i; j++)
                {
                    Console.Write(value % 10 + " ");  // In giá trị giảm dần và thêm khoảng trắng giữa các số
                    value--;
                }

                // Xuống dòng sau mỗi dòng của tam giác
                Console.WriteLine();
            }

        }
    }
}
