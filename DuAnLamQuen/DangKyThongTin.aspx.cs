using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DuAnLamQuen
{
    public partial class DangKyThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddTrinhDo.Items.Add(new ListItem("Trung cấp", "1"));
                ddTrinhDo.Items.Add(new ListItem("Cao đẳng", "2"));
                ddTrinhDo.Items.Add(new ListItem("Đại học", "3"));
                ddTrinhDo.Items.Add(new ListItem("Sau đại học", "4"));

                listNgheNghiep.Items.Add(new ListItem("Kỹ sư", "1"));
                listNgheNghiep.Items.Add(new ListItem("Bác sĩ", "2"));
                listNgheNghiep.Items.Add(new ListItem("Công nhân", "3"));
                listNgheNghiep.Items.Add(new ListItem("Lập trình viên", "4"));

                cblSoThich.Items.Add(new ListItem("Chơi game", "01"));
                cblSoThich.Items.Add(new ListItem("Nghe nhạc", "02"));
                cblSoThich.Items.Add(new ListItem("Xem phim", "03"));
                cblSoThich.Items.Add(new ListItem("Du lịch", "04"));
                cblSoThich.Items.Add(new ListItem("Mua sắm", "05"));
            }

        }

        protected void btnGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            kq += "<h2 class='bg-info w-100'> KẾT QUẢ ĐĂNG KÝ </h2>";
            kq += "<ul class='text-left'>";
            kq += $"<li> Họ tên:<b> {txtHoTen.Text} </b> </li>";
            kq += $"<li> Ngày sinh: <b> {txtNgaySinh.Text} </b> </li>";
            if (radNam.Checked) { 
                kq += $"<li>Giới tính:<b> Nam </b> </li>";
            }
            else
            {
                kq += $"<li>Giới tính: Nữ </li>";
            }
            kq += $"<li> Trình độ:<b> {ddTrinhDo.SelectedItem.Text} </b> </li>";
            kq += $"<li> Nghề nghiệp: <b> {listNgheNghiep.SelectedItem.Text} </b> </li>";
            if (fHinh.HasFile)
            {
                string path = Server.MapPath("~/Uploads");
                string linkImg = path +"/"+ fHinh.FileName;
                fHinh.SaveAs(linkImg);
                kq += $"<li>Ảnh: <img src='Uploads/{fHinh.FileName}'></li>";
            }
            kq += "<li>Sở thích: <b> ";
            int i = 0;
            foreach (ListItem item in cblSoThich.Items)
            {
                i++;
                if (item.Selected)
                {
                    kq += $"{item.Text}";
                    if (cblSoThich.Items.Count != i)
                    {
                        kq += ", ";
                    }
                }               
            }
            kq += "</b></li>";
            kq += "</ul>";

            lbKetQua.Text = kq;
        }
    }
}