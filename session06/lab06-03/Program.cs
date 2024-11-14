namespace lab06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo và khởi tạo danh sách sinh viên sử dụng List generic 
            List<Student> list = new List<Student>()
            {
                new Student{Id="S10",FirstName="Nguyen Hoai",LastName="Phu",Avg=9.5 },
                new Student{Id="S16",FirstName="Nguyen Phi",LastName="Phuong",Avg=9 },
                new Student{Id="S14",FirstName="Trinh Hoai",LastName="Phuong",Avg=8 },
                new Student{Id="S17",FirstName="Nguyen Hoai",LastName="Ngan",Avg=7 },
                new Student{Id="S13",FirstName="Tran Hoai",LastName="Phuong",Avg=9.9 },
                new Student{Id="S11",FirstName="Thuan Hoai",LastName="Phuong",Avg=8.8 },
                new Student{Id="S12",FirstName="Nguyen Ngoc",LastName="Nga",Avg=6.5 },

            };

            //in ra danh sách sinh viên 
            Console.Write("Danh sach sinh vien: ");
            foreach (Student st in list){
                Console.Write(st);
            }

            //tìm sinh viên có điểm trung bình cao nhất 
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list) {
                if (st.Avg > max) { 
                    max = st.Avg;
                    stmax = st;
                }
            }

            //in ra ket qua
            Console.Write("Sinh vien co diem cao nhat la: ");
            Console.Write(stmax);
        }
    }
}
