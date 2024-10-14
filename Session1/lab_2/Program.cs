namespace lab_2
{
    internal class Program
    {
        //Chương trình minh họa việc sử dụng biến, hằng số và kiểu dữ liệu 
        static void Main(string[] args)
        {
            int id = 1;
            string name= "Van Anh";
            byte age = 18;
            char gender = 'A';
            // Khai bao bien hang so 
            const float percent = 75.50F;

            //Hien thi gia tri cac bien va hang so
            Console.WriteLine("Student ID : {0}", id);
            Console.WriteLine("Student Name : {0}", name );
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0}", percent);
        }
    }
}
