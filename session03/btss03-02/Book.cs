using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btss03_02
{
    /// <summary>
    /// Tạo lớp Book để biểu diễn quyển sách 
    /// các trường 
    /// string author
    /// int pages 
    /// string isbn 
    /// string title 
    /// int curent page 
    /// - Tạo constructor mặc định và thiết lập currentpage cho 1 
    /// - Tạo constructor với tất cả các tham số để khởi tạo các trường tương ứng 
    /// - Tạo phương thức flipPageForward (lật sang trang trước)
    /// - Tạo phương thức flipPageBackward (lật sang trang sau)
    /// - Viết chương trình để kiểm thử tất các tính năng của Book 
    /// </summary>
    internal class Book
    {
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentPage { get; private set; }

        //Khai báo danh sách tập hợp chứa thông tin sách
        List<Book> books;

        public Book()
        {
            currentPage = 1;
        }

        public Book(string author, int pages, string isbn, string title, int currentPage)
        { 
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = currentPage>0?currentPage:1;
        }

        //Phương thức lật sang trang trước 
        public void FlipPageForward()
        {
            if (currentPage < pages)
            {
                currentPage++;
            }
            else
            {
                Console.WriteLine("Bạn đã ở trang cuối cùng.");
            }
        }

        //Phương thức lật sang trang sau 
        public void FlipPageBackward()
        {
            if (currentPage > 1)
            {
                currentPage--;
            }
            else
            {
                Console.WriteLine("Bạn đã ở trang đầu tiên.");
            }
        }
    }
}
