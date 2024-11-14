namespace lab05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kkởi tạo đối tượng sinh viên với 3 sinh viên và mỗi sinh vien gồm 2 điẻm 
            Student st = new Student(3, 2);

            //Sử dụng chi mục đẻ truy cập vào thành phần mảng của lớp 
            st[0] = "Nam";
            st[0, 0] = 9;
            st[0, 1] = 10;
            st[1] = "Khanh";
            st[1, 0] = 8;
            st[1, 1] = 10;
            st[2] = "Thu";
            st[2, 0] = 10;
            st[2, 1] = 10;

            //in ra thông tin 
            Console.WriteLine("Thông tin sinh viên: ");
            for (int i = 0; i < st.names.Length; i++) { 
                Console.WriteLine("Ho va ten: " + st[i]);
                Console.Write("Diem: ");
                for (int j = 0; j < st.marks.GetLength(1); j++)
                {
                    Console.Write(st[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
