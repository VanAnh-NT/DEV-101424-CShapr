using Store;
namespace lab07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo mới nhà phân phối cung cấp đây đủ namespace 
            Supply.Manufacturer dealer = new Supply.Manufacturer();

            //gan gia tri
            dealer.Name = "Coca Cola";
            dealer.Email = "coca@gmail.com";
            dealer.Phone = "(111)789-524-666";

            //in ra thong tin 
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);

            //Tạo mới sản phẩm nằm trong namespace Store
            StoreItem si = new StoreItem();

            //gan gia tri
            si.ItemNo = 55489;
            si.ItemName = "Fanta";
            si.Price = 80.56m;

            //in ra thong tin 
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #: ");
            Console.WriteLine(si.ItemNo);

            Console.Write("\t Item Name: ");
            Console.WriteLine(si.ItemName);

            Console.Write("\t Unit Price: ");
            Console.WriteLine(si.Price);
        }
    }
}

