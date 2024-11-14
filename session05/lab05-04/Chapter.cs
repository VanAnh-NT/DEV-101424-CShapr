using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_04
{
    public class Chapter
    {
        private string name;
        private string content;

        //Constructor không có tham số 
        public Chapter() {
            name = "";
            content = "";
        }

        //Constructor có tham số 
        public Chapter(string name, string content)
        { 
            this.name = name;
            this.content = content;
        }

        //định nghĩa các thuộc tính
        public string Name
            { get { return name; } 
              set { name = value; }
            }

        public string Content
        {
            get { return name; }
            set { name = value; }
        }

        //ghi đè các phương thức tostring 
        public override string ToString()
        {
            return name + "\n" + content;
        }
    }
}
