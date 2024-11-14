namespace lab0_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Tạo đối tượng 
            StudentModel action = new StudentModel();

            //Gọi phương thức lấy tất cả sinh viên 
            List<Student> listall = action.GetStudent();

            //Hiển thị 
            foreach (var item in listall) {
                item.Display();
            }

            //Gọi phương thức lấy sinh viên theo Id
            Student st = action.GetStudent(2);

            //Hiển thị 
            st.Display();

            //Gọi phương thức lấy sinh viên có từ 25 - 30 tuổi 
            List<Student> listage = action.GetStudent(25, 30);

            //Hiển thị 
            foreach (var item in listage)
            { 
                item.Display();
            }
        }
    }
}
