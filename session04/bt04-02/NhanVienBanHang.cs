using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_02
{
    internal class NhanVienBanHang : NhanVien
    {
        private float Soluonghangbanduoc;

        protected NhanVienBanHang(float Soluonghangbanduoc) {
            this.Soluonghangbanduoc = Soluonghangbanduoc;
        }

        public override double TinhLuong()
        {
            return Soluonghangbanduoc;
        }

        public override void HienThi()
        {
            Console.WriteLine("Số lượng hàng bán được là: " + Soluonghangbanduoc);
        }
    }
}
