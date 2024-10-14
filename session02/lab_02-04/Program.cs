namespace lab_02_04
{
    internal class Program
    {
        /// <summary>
        /// Chương trình giải phương trình bậc 2 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo các biến 
            double a, b, c, detal, x1, x2;
            //Nhập a, b, c 
            Console.Write("Nhập a = ");
            //a phải != 0 
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hãy nhập lại a khác 0 nhé: \nNhập lại a = ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a == 0);
            
            Console.Write("Nhập b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập c = ");
            c = Convert.ToInt32(Console.ReadLine());
            //Tính detal 
            detal = b * b - 4 * a * c ;
            //Biện luận 
            if (detal < 0) Console.Write("Phương trình vô nghiệm");
            else if (detal == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép");
                Console.WriteLine("x1 = x2 = {0}", -b / (2*a));
            }
            else
            {
                Console.WriteLine("Phương trình có hai nghiệm: ");
                x1 = (-b + Math.Sqrt(detal)) / (2*a);
                Console.WriteLine("x1 = {0}", x1);
                x2 = (-b - Math.Sqrt(detal));
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
