using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_01
{
    internal class ListBox:Window 
    {
        //khai báo trường mới 
        private string listBoxContents;

        //phương thức khởi tạo 
        public ListBox (int top, int left, string contents) : base(top, left)
        {
            listBoxContents = contents;
        }

        //ghi đè phương thức DrawWindow
        public override void DrawWindow()
        {
            base.DrawWindow();//gọi lớp cơ sở 
            Console.Write("Writing string to the listbox: {0}\n", listBoxContents);
        }
    }
}
