using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop
{
    internal class Diem
    {
        private double x, y;
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double tinhKhoangCach(Diem a)
        {
            return Math.Sqrt(Math.Pow((this.x - a.x), 2)
                + Math.Pow((this.y - a.y), 2));
        }

        public double getX
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double getY
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
