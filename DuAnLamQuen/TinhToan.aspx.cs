using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class TinhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }       
        protected void btnCong_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtSo1.Text);
            double soThuHai = Convert.ToDouble(txtSo2.Text);

            double Kq = soThuNhat + soThuHai;
            txtKetQua.Text = Kq.ToString();
        }

        protected void btnTru_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtSo1.Text);
            double soThuHai = Convert.ToDouble(txtSo2.Text);

            double Kq = soThuNhat - soThuHai;
            txtKetQua.Text = Kq.ToString();
        }

        protected void btnNhan_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtSo1.Text);
            double soThuHai = Convert.ToDouble(txtSo2.Text);

            double Kq = soThuNhat * soThuHai;
            txtKetQua.Text = Kq.ToString();
        }

        protected void btnChia_Click(object sender, EventArgs e)
        {
            double soThuNhat = Convert.ToDouble(txtSo1.Text);
            double soThuHai = Convert.ToDouble(txtSo2.Text);

            double Kq = soThuNhat / soThuHai;
            txtKetQua.Text = Kq.ToString();
        }
    }
}