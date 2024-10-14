namespace lab_02_2
{
    /// <summary>
    /// Chương trình tính điện
    /// Nhập vào tên thuê bao, số điện trên công tơ sau đó tính cước theo quy ước sau.
    /// - Nếu số phút gọi <=30 số thì cước phí tính 30$
    /// - Nếu từ 30-50 số thì số trong khoảng (30-50] sẽ tính theo 1.2$ cho mỗi số.
    /// - Nếu trên 50 số thì số trên 50 được tính theo 1.5$ cho mỗi số
    /// - In ra màn hình toàn bộ thông tin
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //output unicode console 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến 
            string name;
            int number;
            double money = 0;
            //Nhập thông tin vào từ bàn phím 
            Console.Write("Nhập tên thuê bao: ");
            name = Console.ReadLine();
            Console.Write("Nhập số điện sử dụng: ");
            number = Convert.ToInt32(Console.ReadLine());
            //tính toán số tiền 
            if (number <= 30) money = 30;
            else if (number > 30 && number <= 50)
                money = 30 + (number - 30) * 1.2;
            else if (number > 50)
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            //in thông tin 
            Console.WriteLine("\n------------Thông tin tiền điện---------------");
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Số điện sử dụng: {0}", number);
            Console.WriteLine("Số tiền: {0:C}", money);
        }
    }
}
