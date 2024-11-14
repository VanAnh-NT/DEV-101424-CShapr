using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_04
{
    internal class Book
    {
        //khai báo trường 
        private string name; 
        //khai báo mảng chương
        private Chapter[] chapters;

        //constructor không tham số 
        public Book() { }

        //Constructor co tham so la so chuong
        public Book(string name, int n)
        {
            this.name = name;
            chapters = new Chapter[n];
        }

        //dinh nghia thuoc tinh
        public string Name
        { 
            get { return name; }
            set { 
            if (value == null)
                    throw new ArgumentNullException("value");
            name = value;
            }
        }

        //Indexer thứ nhất có một tham số kiểu int 
        public Chapter this[int index] {
            get {
                if (index < 0 || index > chapters.Length - 1)
                    return null;
                return chapters[index];
            }
            set { 
                if (index < 0 || index > chapters.Length - 1)
                    throw new ArgumentOutOfRangeException("index");
                chapters[index] = value;
            }
        }

        //Indexer thứ hai có một tham số kiểu string overload indexer 
        public Chapter this[string name]
        {
            get {
                foreach (Chapter ch in chapters)
                {
                    if (ch.Name == name)
                    {
                        return ch;
                    }

                }
                return null;
            }
        }
    }
}
