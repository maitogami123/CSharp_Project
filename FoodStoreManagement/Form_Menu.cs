using DAL;
using FoodStoreManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_Menu : Form
    {
        Form_NhapHang form_NhapHang;
        Form_DSNguyenLieu form_MatHang;
        Form_Kho form_Kho;
        Form_DSKhuyenMai form_DSKhuyenMai;
        Form_DatBan form_DatBan;
        Form_DSMonAn form_DatHang;
        Form_DoanhThuTongQuan form_DoanhThuTongQuan;
        Form_GioHang form_GioHang;
        Form_HoaDon form_HoaDon;
        Form_LapHoaDon form_LapHoaDon;
        Form_QuanLyTaiKhoan form_QuanLyTaiKhoan;
        Form_DSDatBan form_DSDatBan;
        Form_DangNhap form1;
        Form_TrangChu form_TrangChu;
        Form_DSBan form_DSBan;
        public Form_Menu()
        {
            InitializeComponent();
            form_NhapHang = new Form_NhapHang();
            form_NhapHang.TopLevel = false;
            panel_FormContainer.Controls.Add(form_NhapHang);
        }
        public Form_Menu(Form_DangNhap form_DangNhap)
        {
            InitializeComponent();
            form1= form_DangNhap;
            form_NhapHang = new Form_NhapHang();
            form_NhapHang.TopLevel = false;
            panel_FormContainer.Controls.Add(form_NhapHang);
            form_MatHang = new Form_DSNguyenLieu();
            form_MatHang.TopLevel = false;
            panel_FormContainer.Controls.Add(form_MatHang);
            form_Kho = new Form_Kho();
            form_Kho.TopLevel = false;
            panel_FormContainer.Controls.Add(form_Kho);
            form_DSKhuyenMai = new Form_DSKhuyenMai();
            form_DSKhuyenMai.TopLevel = false;
            panel_FormContainer.Controls.Add(form_DSKhuyenMai);
            form_DatHang = new Form_DSMonAn();
            form_DatHang.TopLevel = false;
            panel_FormContainer.Controls.Add(form_DatHang);
            form_DatBan = new Form_DatBan();
            form_DatBan.TopLevel = false;
            panel_FormContainer.Controls.Add(form_DatBan);
            form_DoanhThuTongQuan = new Form_DoanhThuTongQuan();
            form_DoanhThuTongQuan.TopLevel = false;
            panel_FormContainer.Controls.Add(form_DoanhThuTongQuan);
            form_GioHang = new Form_GioHang();
            form_GioHang.TopLevel = false;
            panel_FormContainer.Controls.Add(form_GioHang);
            form_HoaDon = new Form_HoaDon();
            form_HoaDon.TopLevel = false;
            panel_FormContainer.Controls.Add(form_HoaDon);
            form_LapHoaDon = new Form_LapHoaDon();
            form_LapHoaDon.TopLevel = false;
            panel_FormContainer.Controls.Add(form_LapHoaDon);
            form_QuanLyTaiKhoan = new Form_QuanLyTaiKhoan();
            form_QuanLyTaiKhoan.TopLevel = false;
            panel_FormContainer.Controls.Add(form_QuanLyTaiKhoan);
            form_DSBan = new Form_DSBan();
            form_DSBan.TopLevel = false;
            panel_FormContainer.Controls.Add(form_DSBan);
            form_TrangChu = new Form_TrangChu();
            form_TrangChu.TopLevel = false;
            panel_FormContainer.Controls.Add(form_TrangChu);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (AccountDAL.Instance.UserName != null)
            {
                button6.Text = AccountDAL.Instance.UserName;
            }
            if (AccountDAL.Instance.UserName != "Admin")
            {
                button_DSTaiKhoan.Enabled = false;
            }
            if (AccountDAL.Instance.UserName != "QL")
            {
                button_NhapHang.Enabled = false;
                button_DSThongKe.Enabled = false;
                button_DSKhuyenMai.Enabled = false;
                button_Kho.Enabled = false;
            }
        }
        private void button_Home_Click(object sender, EventArgs e)
        {
            if (form_TrangChu.Visible == false)
            {
                form_TrangChu.Visible = true;
            }
            else
            {
                form_TrangChu.Visible = false;
            }
        }

        private void button_DatHang_Click(object sender, EventArgs e)
        {
            if (form_DatHang.Visible == false)
            {
                form_DatHang.Visible = true;
            }
            else
            {
                form_DatHang.Visible = false;
            }
        }

        private void button_DatBan_Click(object sender, EventArgs e)
        {
            if (form_DatBan.Visible == false)
            {
                form_DatBan.Visible = true;
            }
            else
            {
                form_DatBan.Visible = false;
            }
        }

        private void button_GioHang_Click(object sender, EventArgs e)
        {
            if (form_GioHang.Visible == false)
            {
                form_GioHang.Visible = true;
            }
            else
            {
                form_GioHang.Visible = false;
            }
        }

        private void button_DSTaiKhoan_Click(object sender, EventArgs e)
        {
            if (form_QuanLyTaiKhoan.Visible == false)
            {
                form_QuanLyTaiKhoan.Visible = true;
            }
            else
            {
                form_QuanLyTaiKhoan.Visible = false;
            }
        }

        private void button_Kho_Click(object sender, EventArgs e)
        {
            if (form_Kho.Visible == false)
            {
                form_Kho.Visible = true;
            }
            else
            {
                form_Kho.Visible = false;
            }
        }

        private void button_DSThongKe_Click(object sender, EventArgs e)
        {
            if (form_DoanhThuTongQuan.Visible == false)
            {
                form_DoanhThuTongQuan.Visible = true;
            }
            else
            {
                form_DoanhThuTongQuan.Visible = false;
            }
        }

        private void button_DSSanPham_Click(object sender, EventArgs e)
        {
            if (form_MatHang.Visible == false)
            {
                form_MatHang.Visible = true;
            }
            else
            {
                form_MatHang.Visible = false;
            }
        }

        private void button_DSKhuyenMai_Click(object sender, EventArgs e)
        {
            if (form_DSKhuyenMai.Visible == false)
            {
                form_DSKhuyenMai.Visible = true;
            }
            else
            {
                form_DSKhuyenMai.Visible = false;
            }
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            if (form_NhapHang.Visible==false)
            {
                form_NhapHang.Visible = true;
            }
            else
            {
                form_NhapHang.Visible=false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel_FormContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_DSBan_Click(object sender, EventArgs e)
        {
            if (form_DSBan.Visible == false)
            {
                form_DSBan.Visible = true;
            }
            else
            {
                form_DSBan.Visible = false;
            }
        }
    }
}
