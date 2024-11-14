namespace bt_02_03
{
    internal class Program
    {
        /// <summary>
        /// Nhập vào số nguyên dương là số giây, in ra định dạng sau hh:mm:ss.
        /// Ví dụ: số giây nhập vào là 350 thì in ra là 00:05:50
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int second;
            Console.Write("Nhập vào số giây muốn quy đổi: ");
            second = Convert.ToInt32(Console.ReadLine());

            if(second<0)
            {
                Console.Write("Đừng quy đổi thời gian quá khứ nũa hãy quy đổi thời gian hiện tại: ");
                second = Convert.ToInt32(Console.ReadLine());
            }else
            {
                int hours = second / 3600;
                int minutes = (second % 3600) / 60;
                int seconds = second % 60;
                Console.Write($"{hours:D2}:{minutes:D2}:{seconds:D2}");
                Console.Write($"{hours:D2}:{minutes:D2}:{seconds:D2}");
            } 
        }
    }
}
