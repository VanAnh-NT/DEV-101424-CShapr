using Business;
using Business.Dealership;
namespace lab07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới đối tượng House trong namespase Business 
            //có thể sử dụng ở trên đầu tệp tin để viết ngắn gọn hơn 
            House h = new House();
            //gán thông tin 
            h.HouseNo = "D294FF";
            h.Price = 425880;

            //in ra thông tin 
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No: "+h.HouseNo);
            Console.WriteLine("\t Price: "+h.Price);

            //tạo mới đối tượng car trong namespace Business.Dealership 
            //có thể sử dụng using trên đầu tệp tin để viết ngắn gọn hơn 
            Car c = new Car();
            c.CarNo = "A0999";
            c.Price = 38425.50m;

            //in ra thông tin 
            Console.WriteLine("Car Detail: ");
            Console.WriteLine("\t Car no: "+c.CarNo);
            Console.WriteLine("\t Price: "+c.Price);
        }
    }
}
