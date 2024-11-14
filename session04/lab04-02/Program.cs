namespace lab04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo thông tin sinh viên cao đang in ra sinh viên 
            Console.WriteLine("---Student College---");
            StudentCollege svcd = new StudentCollege("Truong", 1999, 8.5, 9, 7.75);
            svcd.Display();
            Console.WriteLine("Average of score: {0:N2}", svcd.Average());

            //Khởi tạo thông tin sinh viên đại học và in ra thông tin sinh viên 
            Console.WriteLine("+++Student University+++");
            StudentUniversity svdh = new StudentUniversity("Thanh", 2000, 9, 9, 9, 9);
            svdh.Display();
            Console.WriteLine("Average of score: {0:N2}", svdh.Average());
        }
    }
}
