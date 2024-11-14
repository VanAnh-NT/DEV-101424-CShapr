using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bt_02_02
{
    internal class Program
    {
        /// <summary>
        /// Chương trình nhập vào năm x và tháng y sau đó in ra số ngày trong thắng đó 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x;
            int y;


            Console.Write("Hãy nhập năm muốn biết số ngày trong tháng: ");
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (!(x >= 1000 && x <= 9999))
                {
                    Console.Write("Vui lòng nhập lại số năm hợp lệ từ 1000-9999: ");
                }

            } while (!(x >= 1000 && x <= 9999));


            Console.Write("Nhập tháng (1-12): ");
            do
            {
                y = Convert.ToInt32(Console.ReadLine());

                if (y < 1 || y > 12)
                {
                    Console.WriteLine("Vui lòng nhập tháng trong khoảng 1 đến 12.");
                }
            } while (y < 1 || y > 12);

            switch (y)
            {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Tháng vừa nhập có 31 ngày");
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Tháng vừa nhập có 30 ngày");
                        break;

                    case 2:
                        if (x % 4 == 0 && !(x % 100 == 0 && x % 400 != 0))
                        {
                            Console.WriteLine("Thang 2 co 29 ngay");
                        }
                        else Console.WriteLine("Thang 2 co 28 ngay");
                        break;
            }
           
        }
    }
}
