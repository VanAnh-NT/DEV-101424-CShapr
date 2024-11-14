using System.Text;

namespace bt_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo
            int id;
            string name, address;
            DateTime birthday;
            double salary, bonus, totalSalary;
            //Nhập thông tin 
            Console.Write("Nhập Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
  
            Console.Write("Nhập ngày sinh: ");
            birthday = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nhập lương: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập thưởng: ");
            bonus = Convert.ToDouble(Console.ReadLine());
            //In toàn ộ thông tin 
            Console.WriteLine("--------------Những thông tin vừa nhập là ---------------");
            Console.WriteLine("Id vừa nhập là: " + id);
            Console.WriteLine("Tên cuả bạn là: " + name);
            Console.WriteLine("Địa chỉ của bạn là: "+address );
            Console.WriteLine("Ngày sinh của bạn là: " + birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Mức lương bạn vừa nhập là: " + salary);
            Console.WriteLine("Phần thưởng của bạn là: " + bonus);
            Console.WriteLine("Tổng tiền lương : {0}",  totalSalary=salary+bonus);
        }
    }
}
