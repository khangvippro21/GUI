using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class HinhTron
    {
        private Diem tam;
        private double banKinh;

        public HinhTron(Diem tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }

        public double tinhDienTich()
        {
            double dt = (this.banKinh * 2) * Math.PI;
            return dt;
        }

        public double tinhChuVi()
        {
            double cv = 2 * Math.PI * (this.banKinh);
            return cv;
        }

        public int viTriTuongDoi(Diem a)
        {
            double vt = this.tam.tinhKhoangCach(a);
            if(vt > this.banKinh)
            {
                return 1;
            }else if (vt < this.banKinh) { return -1;}

            return 0;
        }
    }
}
