using System.Collections;

namespace lab06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo ra ArrayList
            ArrayList inv = new ArrayList();

            //Them phan tu vao danh sach 
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));

            //In ra danh sach phan tu 
            Console.WriteLine("Product list: ");
            foreach (Product prod in inv)
            {
                Console.WriteLine("   "+ prod);
            }
        }
    }
}
