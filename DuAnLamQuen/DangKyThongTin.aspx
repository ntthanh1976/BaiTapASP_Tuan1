<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKyThongTin.aspx.cs" Inherits="DuAnLamQuen.DangKyThongTin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        input[type=text],input[type=date] {
            width: 100%;
            border: 1px solid #aaa;
            border-radius: 4px;
            margin: 8px 0;
            outline: none;
            box-sizing: border-box;
            transition: .3s;
        }

            input[type=text]:focus {
                border-color: dodgerBlue;
                box-shadow: 0 0 8px 0 dodgerBlue;
            }
            input[type=date]:focus {
                border-color: dodgerBlue;
                box-shadow: 0 0 8px 0 dodgerBlue;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
      
        <div class="text-center mt-3 border border-info">
            <h1 class="bg-info">ĐĂNG KÝ THÔNG TIN</h1>
            <div class="row mb-2">
                <div class="col-2 text-right mt-2">
                    <asp:Label ID="lbHoTen" runat="server" Text="Họ và tên:"></asp:Label>
                </div>
                <div class="col-8">
                    <asp:TextBox Width="100%" CssClass="form-control" ID="txtHoTen" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row mb-2">
                <div class="col-2 text-right mt-2">
                    <asp:Label ID="lbNgaySinh" runat="server" Text="Ngày sinh:"></asp:Label>
                </div>
                <div class="col-8">
                    <asp:TextBox TextMode="Date"  CssClass="form-control" Width="100%" ID="txtNgaySinh" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row mb-2">
                <div class="col-2 text-right">
                    <asp:Label ID="lbGioiTinh" runat="server" Text="Giới tính:"></asp:Label>
                </div>
                <div class="col-8 text-left">
                    <asp:RadioButton ID="radNam"  Checked="true" runat="server" GroupName="GT" Text="Nam" />
                    <asp:RadioButton ID="radNu"  runat="server" GroupName="GT" Text="Nữ" />
                </div>
            </div>

            <div class="row mb-2">
                <div class="col-2 text-right">
                    <asp:Label ID="lbTrinhDo" runat="server" Text="Trình độ:"></asp:Label>
                </div>
                <div class="col-8 text-left">
                    <asp:DropDownList ID="ddTrinhDo"  CssClass="form-control" Width="100%" runat="server"></asp:DropDownList>
                </div>
            </div>

            <div class="row mb-2">
                <div class="col-2 text-right">
                    <asp:Label ID="lbNgheNghiep" runat="server" Text="Nghề nghiệp:"></asp:Label>
                </div>
                <div class="col-8 text-left">
                    <asp:ListBox ID="listNgheNghiep"  CssClass="form-control" Width="100%" runat="server"></asp:ListBox>
                </div>
            </div>

            <div class="row mb-2">
                <div class="col-2 text-right">
                    <asp:Label ID="lbHinh" runat="server" Text="Hình:"></asp:Label>
                </div>
                <div class="col-8 text-left">
                    <asp:FileUpload ID="fHinh"  CssClass="form-control" Width="100%" runat="server" />
                </div>
            </div>

            <div class="row mb-2">
                <div class="col-2 text-right">
                    <asp:Label ID="lbSoThich" runat="server" Text="Sở thích:"></asp:Label>
                </div>
                <div class="col-8 text-left">
                    <asp:CheckBoxList ID="cblSoThich" RepeatColumns="2" RepeatDirection="Vertical"  runat="server"></asp:CheckBoxList>
                </div>
            </div>
            <div class="row mb-2">
                <div class="col-2"></div>
                <div class="col-10 text-left">
                    <asp:Button CssClass="btn btn-success pl-4 pr-4" ID="btnGui" runat="server" Text="Gửi" OnClick="btnGui_Click" />
                    <asp:Button CssClass="btn btn-danger pl-4 pr-4" ID="btnLamLai" runat="server" Text="Làm lại" />
                </div>

            </div>
            <div class="row mb-2">               
                <div class="col-12">
                    <asp:Label ID="lbKetQua" runat="server" Text=""></asp:Label>
                </div>

            </div>
        </div>
       </div>
    </form>
</body>
</html>
