namespace bt_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap vao lan luot ba so nguyen a, b, c: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a+b >c && a + c > b && c + b > a) {
                if (a == b && b == c && a == c) {
                    Console.WriteLine("tg deu");
                }
                else if ((a == b && a != c) || (b == c && c!=a) || (a == c && c != b)) {
                    Console.WriteLine("tg can");
                }
                else if ((a*a + b*b == c*c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                {
                    Console.WriteLine("tg vuong");
                }
                else Console.WriteLine("tg binh thuong");
               
            }
            else Console.WriteLine("a, b, c KHONG tao thanh ba canh cua tam giac");
        }
    }
}
