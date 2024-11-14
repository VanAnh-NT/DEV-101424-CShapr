using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_02
{
    internal class CongNhan : NhanVien
    {
        protected int Soluongsanpham;

        public CongNhan(int Soluongsp) {
            Soluongsanpham = Soluongsp;
        }

        public override double TinhLuong()
        {
            return Soluongsanpham;
        }

        public override void HienThi()
        {
            Console.WriteLine("Số lượng sản phẩm là: "+ Soluongsanpham);
        }
    }
}
