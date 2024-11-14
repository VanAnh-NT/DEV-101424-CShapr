namespace lab3_04
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh họa việc sử dụng từ khóa ref và out 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 20, b = 30;
            double hehe;
            Utility u = new Utility();
            Console.WriteLine("Truoc khi hoan vi a={0}, b={1}", a, b);

            u.SwapFake(a, b);
            Console.WriteLine("Sau khi hoan vi dang fake a={0}, b={1}", a, b);

            u.SwapReally(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi dang really a={0}, b={1}", a, b);

            u.AreaCircle(100, out hehe);
            Console.WriteLine("Chu vi hinh tron ban kinh 100 la: " + hehe);
        }
    }
}
