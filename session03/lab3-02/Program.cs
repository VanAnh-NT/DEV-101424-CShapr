namespace lab3_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Tạo đối tượng cới contact với constructor không tham số 
            Contact ct1 = new Contact();

            //gán giá trị cho ct1 
            ct1.Id = 6;
            ct1.FirstName = "Phương Phùng";
            ct1.LastName = "Bùi Thoa";
            ct1.Address = "Hà Nội";
            ct1.Phone = "0978735922";
            ct1.Email = "hoangha@gmail.com";

            //Tạo đối tượng contact với constructor có tham số 
            Contact ct2 = new Contact(5, "Phùng Điểu", "Khả Ái", "Tuyên Quang", "0987654325", "phungai@gmail.com");

            //Hiển thị thông tin ct1 và ct2 
            ct1.Display();
            ct2.Display();

        }
    }
}
