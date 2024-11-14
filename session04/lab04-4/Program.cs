namespace lab04_4
{
    internal class Program
    {
        /// <summary>
        /// Tạo lớp IPerson với các phương thức Insert, Delete, Update, Display
        /// Tạo lớp Staff thực thi các phương thức trong giao diện IPerson
        /// Tạo lớp Student với các trường Id, Name, age và thực thi các phương thức trong giao diện IPerson 
        /// Trong Main code để test 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //tạo một nhân viên 
            IPerson staff = new Staff();
            object data = "Bèo dạt mây trôi";
            //gọi các hành động 
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);


            //tạo nhân viên 
            IPerson student = new Student()
            {
                Id = "SV12",
                Name = "Phong",
                Age = 24
            };
            //hiển thị dữ liệu 
            student.Display(student);

        }
    }
}
