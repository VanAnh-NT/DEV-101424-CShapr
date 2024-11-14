namespace lab06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo sortedlist generic 
            SortedList<string, string> listEm = new SortedList<string, string>();

            //đưa dữ liệu vào 
            listEm.Add("E01", "Tran Thi Thuy");
            listEm.Add("E02", "Le Hai Ha");
            listEm.Add("E03", "Nguyen Van Hung");
            listEm.Add("E04", "Hoang Thi Thom");
            listEm.Add("E05", "Trinh Van Chien");
            listEm.Add("E06", "Bui Bao Ngoc");

            //in danh sach 
            Console.WriteLine("Danh sach nhan vien");
            foreach (var key in listEm.Keys)
            { 
                Console.WriteLine(key + ":" + listEm[key]);
            }

            //tìm kiếm tất cả các nhân viên có tên bắt đầu bằng chữ Th 
            Console.WriteLine("Danh sach nhan vien bat dau bang chu Th la:");
            foreach (string key in listEm.Keys)
            { 
                if (listEm[key].Contains("Th"))
                    Console.WriteLine(key + ": " +listEm[key]);
            }

            //Xóa nhân viên có mã E04
            listEm.Remove("E04");

            //Kiểm tra nếu chưa có nhân viên E06 thì thêm vào 
            if (!listEm.ContainsKey("E06"))
                listEm.Add("E06", "Nguyen Thi Hoai Linh");

            //In danh sach sau khi xoa, them
            Console.WriteLine("Danh sach nhan vien sau khi xoa va them la: ");
            foreach (string key in listEm.Keys) {
                Console.WriteLine(key + ": " + listEm[key]);
            }
        }
    }
}
