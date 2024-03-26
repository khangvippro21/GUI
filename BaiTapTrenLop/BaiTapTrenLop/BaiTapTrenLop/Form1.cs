using System.Data;

namespace BaiTapTrenLop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btThucHien_Click(object sender, EventArgs e)
        {
            
            if (rdDienTich.Checked)
            {
                
                double a = double.Parse(txtHtronX.Text);
                double b = double.Parse(txtHtronY.Text);
                double r = double.Parse(txtBanKinh.Text);
                Diem tam = new Diem(a, b);
                HinhTron ht = new HinhTron(tam, r);

                lbKetQua.Text = String.Format("{0:0.##}", ht.tinhDienTich());
            }
            else if (rdChuVi.Checked)
            {
                double a = double.Parse(txtHtronX.Text);
                double b = double.Parse(txtHtronY.Text);
                double r = double.Parse(txtBanKinh.Text);
                Diem tam = new Diem(a, b);
                HinhTron ht = new HinhTron(tam, r);

                lbKetQua.Text = String.Format("{0:0.##}", ht.tinhChuVi());
            }
            else
            {
                double a = double.Parse(txtHtronX.Text);
                double b = double.Parse(txtHtronY.Text);
                double r = double.Parse(txtBanKinh.Text);
                Diem tam = new Diem(a, b);
                HinhTron ht = new HinhTron(tam, r);


                double c = double.Parse(txtTamX.Text);
                double d = double.Parse(txtTamY.Text);
                Diem xet = new Diem(c, d);
                if (ht.viTriTuongDoi(xet) > 0)
                {
                    lbKetQua.Text = "Điểm nằm ngoài đường tròn!";
                }
                else if(ht.viTriTuongDoi(xet) < 0)
                {
                    lbKetQua.Text = "Điểm nằm trong đường tròn! ";
                }
                else
                {
                    lbKetQua.Text = "Điểm nằm trên đường tròn!";
                }
            }
        }
    }
}
