using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace bt_01
{/// <summary>
///     Author: Van Anh
///     Date: 10
///     Objective: 
///     Dùng để làm document cho người khác làm việc về sau, nên khai báo đủ ra những giá trị cần thiết 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Xuất file có unicode 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến 
            int id;
            string name;
            DateTime birth;
            char gender;
            string address;
            int phone;
            string email;
            //Nhập dữ liệu cho biến 
            id = 1;
            name = "Hoang Phung Phuong Hoa";
            birth = DateTime.Now;
            gender = 'F';
            address = "Ha Noi";
            phone = 021598463;
            email = "hoangphungphuonghoa@gmail.com";
            //In ra màn hình 
            Console.WriteLine("ID : {0}", id);
            Console.WriteLine("Ho va tên : {0}", name);
            Console.WriteLine("Ngay sinh : "+ String.Format("{0:MM/dd/yyyy}", birth));
            Console.WriteLine("Gioi tinh: {0}", gender);
            Console.WriteLine("Dia chi : {0}", address);
            Console.WriteLine("So dien thoai : {0}", phone);
            Console.WriteLine("Email : " +email);
        }
    }
}
