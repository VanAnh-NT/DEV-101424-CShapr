using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_02
{
    abstract class NhanVien
    {
        protected string Ten;
        protected string DiaChi;

        public abstract double TinhLuong();

        public abstract void HienThi();
    }
}
