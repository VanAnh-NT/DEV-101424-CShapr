namespace bt_02_04
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các số tổng 3 ký tự là số chẵn từ 100-999
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.Write("Những số có tổng ba số nằm trong khoảng 100-999 là số chẵn là: ");
            int counts = 0;
            for (int i = 100; i<=999; i++)
            {
                int hundreds = i / 100;
                int tens = (i % 100) / 10;
                int units = i % 10;

                int sum = hundreds + tens + units;
                if (sum % 2 == 0)
                {
                    Console.Write($"{i} ");
                    counts++;
                }
            }
            Console.WriteLine($"\nCó {counts} số thỏa mãn điều kiện trên");
        }
    }
}
