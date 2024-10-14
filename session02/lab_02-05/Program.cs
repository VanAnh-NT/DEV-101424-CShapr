namespace lab_02_05
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các số nguyên từ 2 - 100 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến đánh dấu 
            bool check_i;
            Console.Write("Danh sách các số nguyên tố từ 2 - 100: ");
            for (int i = 2; i<=100; i++)
            {
                check_i = true;//Giả sử i là số nguyên tố 
                for (int j = 2; j <=i/2; j++ )//Duyệt từ 2 - j/2
                {
                    if (i%j ==0) //Nếu i chia hết cho j thì 
                    {
                        check_i = false;//kết luận không là số nguyên tố 
                        break;//Thoát khỏi vòng lặp hiện tại 
                    }
                }
                if (check_i) //nếu giả sử vẫn đúng -> i là số nguyên tố 
                    Console.Write(" {0}", i);
            }
        }
    }
}
