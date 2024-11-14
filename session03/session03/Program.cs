namespace lab3_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Tạo đối tượng Car 
            Car myCar = new Car();
            //Gán giá trị cho các trường đối tượng 
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 1995;

            //Hiển thị thông tin về đối tượng myCar 
            System.Console.WriteLine("Thông tin chi tiết: ");
            System.Console.WriteLine("Được tạo bởi hãng: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year release: " + myCar.year);

            //Gọi phương thức 
            myCar.Start();
            myCar.Stop();
        }
    }
}
