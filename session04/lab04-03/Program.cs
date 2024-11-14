namespace lab04_03
{
    internal class Program
    {
        /// <summary>
        /// Tạo lớp trừu tượng Shape với các trường radius, length, width. Khai báo hai phương thức trừu tượng tính diện tích Area và tínhc hu vi Cỉumference
        /// Tạo lớp Cỉcle kế thừa từ lớp Shape và thực thi các phương thức của lớp Shape 
        /// Tạo lớp Rectangle kế thừa từ Shape và thực thi các phương thức của lớp Shape 
        /// Trong Main viết code để test chương trình 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khởi tạo hình chữ nhật 
            Rectangle chunhat = new Rectangle();
            //nhập dữ liệu chiều dài và chiều rộng 
            chunhat.InputData();
            //In thông tin 
            Console.WriteLine("Diện tích hình chữ nhật là: {0:N}", chunhat.Area());
            Console.WriteLine("Chu vi hình chữ nhật là: {0:N}", chunhat.Cỉcumference());
            
            //Khởi tạo hình tròn 
            Circle hinhtron = new Circle();
            //Nhập bán kính 
            hinhtron.InputData();
            //in ra thông tin 
            Console.WriteLine("Diện tích hình tròn là: {0:N2}", hinhtron.Area());
            Console.WriteLine("Chu vi hình tròn là: {0:N2}", hinhtron.Cỉcumference());
        }
    }
}
