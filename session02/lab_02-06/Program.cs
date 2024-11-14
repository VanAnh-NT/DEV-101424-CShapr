namespace lab_02_06
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình khai báo và khởi tạo một mảng tên, dùng foreach để in mỗi tên trên một dòng 
        /// Sử dụng foreach để in ra danh sách các phần tử của mảng 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo và khởi tạo mảng tên 
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            Console.Write("Danh sach sinh vien: \n");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
