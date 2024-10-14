namespace lab_02
{/// <summary>
/// Chương trình minh họa việc nhập xuất trông ứng dụng console 
/// Nhập vào mã sinh viên, tên sinh viên, ngày sinh và điểm 3 môn
/// In ra thông tin sinh viên và điểm trung bình 
/// </summary>
/// <param name="args"></param>
    internal class Program
    {
        static void Main(string[] args)
        {
            //unicode console
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo các biến 
            string id, name;
            double mark1, mark2, mark3, average;
            DateTime birthday;
            //Nhập sữ liệu từ bàn phím 
            Console.Write("Nhập mã số: ");
            id = Console.ReadLine();
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập điểm môn 1: ");
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập điểm môn 2: ");
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập điểm môn 3: ");
            mark3 = Convert.ToDouble(Console.ReadLine());
            //Tính điểm trung bình 
            average = (mark1 + mark2 + mark3) / 3;
            //In thông tin ra màn hình 
            Console.WriteLine("\n--------Thông tin sinh viên---------");
            Console.WriteLine("Mã số: {0}", id);
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Ngày sinh: {0:dd/MM/yyyy}", birthday);
            Console.WriteLine("Điểm thứ nhất: {0:N}, Điểm thứ hai: {1:N}, Điểm thứ ba: {2:N}", mark1, mark2, mark3);
            Console.WriteLine("Điểm trung bình: {0:N}", average);
        }
    }
}
