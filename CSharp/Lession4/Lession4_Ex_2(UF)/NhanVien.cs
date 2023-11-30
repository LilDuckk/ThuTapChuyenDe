using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4_Ex_2
{
    abstract class NhanVien
    {
        protected string Ten;
        protected string DiaChi;

        public NhanVien() { }

        public NhanVien(string Ten, string DiaChi)
        {
            this.Ten = Ten;
            this.DiaChi = DiaChi;
        }

        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}