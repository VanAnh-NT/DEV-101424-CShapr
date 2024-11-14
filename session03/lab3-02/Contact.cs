using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_02
{
    internal class Contact
    {
        //Khai báo các trường 
        public int id;
        public string firstname;
        public string lastname;
        public string address;
        public string phone;
        public string email;

        //tạo Constructor không tham số 
        public Contact()
        { }

        //Tạo Constructor với các tham số 
        public Contact(int id, string firstname, string lastname, string address, string phone, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        //Tạo thuộc tính cho các trường 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName { 
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName 
            { get { return lastname; } set { lastname = value; } }

        public string Address
        { get { return address; } set { address = value; } }

        public string Phone 
        { get { return phone; } set { phone = value; } }

        public string Email 
        { get { return email; } set { email = value; } }

        //Định nghĩa phương thức display 
        public void Display()
        {
            Console.WriteLine("Mã số: " + id);
            Console.WriteLine("Họ và tên: {0} {1}", firstname, lastname);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("Điện thoại: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}
