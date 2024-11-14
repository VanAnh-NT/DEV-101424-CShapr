namespace btss03_01
{
    internal class Program
    {
        /// <summary>
        /// Tạo lớp Employee với mô tả 
        /// các thành phần dữ liệu 
        /// id kiểu int 
        /// name kiểu String 
        /// yearOfBirth kiểu int 
        /// salaryLevel kieu double 
        /// basicSalary kiểu double(Lưu ý basicSalary là trường được sử dụng chung cho mọi đối tượng của lớp Employee)
        /// Phương thức GetIncome() trả lại thu nhập của nhân viên, thu nhập đuọc tính bàng salaryLevel * basicSalary
        /// Phương thức Display() hiển thị thông tin về nhân viên bao gồm id, name, yearOfBirth, basicSalary, thu nhập 
        /// Viết chương trình cài cài đặt lớp employee và lớp ự dụng Employee 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Employee.basicSalary = 30000000;
            Employee epl1 = new Employee();

            //gán gía trị cho epl1 
            epl1.Id = 1;
            epl1.Name = "Thoa";
            epl1.yearOfBirth = 2009;
            epl1.salaryLevel = 2;
            


            epl1.Display();
        }
    }
}
