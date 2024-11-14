using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_03
{
    /// <summary>
    /// Tạo một giao diện tên là IStoreable với các phương thức Write() để lưu nội dung của đối tượng vào file và phương thức Read() để dộc dữ liệu từ file. Sau đó tạo lớp Document thực thi giao diện Ítorable để các đối tượng thuọc lớp này có thể đọc từ cơ sở dữ liệu hocwj lưu trữ vào cơ sở dữ liệu. Việc mở file được thực hiện thông qua đối tượng fs thuộc lớp FileStream, việc ghi và đọc file thông qua đối tượng thuộc các lớp StreamWriter và StreamReader. Đồng thời lớp Document cũng thự thi một giao diện khác tên là IEncryptable, giao diện này có hai phương thưc là ENcrypt() và Decrypt(). Các phương thức được thực thi ở Document chỉ cần in ra thông báo tương ứng  
    /// </summary>
    internal class Document : IStorage, IEncryptable 
    {
        private string Content;

        public Document(string content) {
            Content = content;
        }

        public void Write(string filename) {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            using (StreamWriter write = new StreamWriter(fs))
            { 
                write.Write(Content);
                Console.WriteLine($"Noi dung da duoc ghi vao file: {filename}");
            
            }
            }

        public void Read(string filename) {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                Content = reader.ReadToEnd();
                Console.WriteLine($"Nội dung đã được đọc từ file: {filename}");
                Console.WriteLine($"Nội dung là: {Content}");

            }
        }

        public void Encrypt() { 
        Console.WriteLine("File đã được mã hóa");    
        }

        public void Decrypt()
        {
            Console.WriteLine("Nội dung đã được giải mã");
        }
    }
}
