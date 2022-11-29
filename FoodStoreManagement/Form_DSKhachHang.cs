using FoodStoreManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodStoreManagement.GUI
{
    public partial class Form_DSKhachHang : Form
    {
        string PlaceHolder1 = "Tìm kiếm";
        string PlaceHolder2 = "Nhập mã khách hàng";
        string PlaceHolder3 = "Nhập tên khách hàng";
        string PlaceHolder4 = "Nhập số điện thoại";
        string PlaceHolder5 = "Nhập địa chỉ";
        public Form_DSKhachHang()
        {
            InitializeComponent();
            comboBox3.Items.Add("Vãng lai");
            comboBox3.Items.Add("Thân thiết");
            comboBox3.Items.Add("Tiềm năng");
            loadtable();
        }

        private void Form_DSKhachHang_Load(object sender, EventArgs e)
        {
            textBox_TimKiem.LostFocus += TextBox_LostFocus;
            textBox2.LostFocus += TextBox_LostFocus;
            textBox3.LostFocus+= TextBox_LostFocus;
            textBox4.LostFocus += TextBox_LostFocus;
            textBox5.LostFocus += TextBox_LostFocus;
            textBox_TimKiem.GotFocus += TextBox_GotFocus;
            textBox2.GotFocus+= TextBox_GotFocus;
            textBox3.GotFocus+= TextBox_GotFocus;
            textBox4.GotFocus+= TextBox_GotFocus;
            textBox5.GotFocus+= TextBox_GotFocus;
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            if(textBox_TimKiem.Text==PlaceHolder1)
            {
                textBox_TimKiem.ForeColor= Color.Black;
                textBox_TimKiem.Text = "";
            }
            if(textBox2.Text==PlaceHolder2)
            {
                textBox2.ForeColor= Color.Black;
                textBox2.Text = "";
            }
            if(textBox3.Text==PlaceHolder3)
            {
                textBox3.ForeColor= Color.Black;
                textBox3.Text = "";
            }
            if(textBox4.Text==PlaceHolder4)
            {
                textBox4.ForeColor= Color.Black;
                textBox4.Text = "";
            }
            if(textBox5.Text==PlaceHolder5)
            {
                textBox5.ForeColor= Color.Black;
                textBox5.Text = "";
            }    
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if(textBox_TimKiem.Text=="")
            {
                textBox_TimKiem.ForeColor= Color.Gray;
                textBox_TimKiem.Text = "Tìm kiếm";
            }    
            if(textBox2.Text=="")
            {
                textBox2.ForeColor= Color.Gray;
                textBox2.Text = "Nhập mã khách hàng";
            }    
            if(textBox3.Text=="")
            {
                textBox3.ForeColor= Color.Gray;
                textBox3.Text = "Nhập tên khách hàng";
            }    
            if(textBox4.Text=="")
            {
                textBox4.ForeColor= Color.Gray;
                textBox4.Text = "Nhập số điện thoại";
            }    
            if(textBox5.Text=="")
            {
                textBox5.ForeColor= Color.Gray;
                textBox5.Text = "Nhập địa chỉ";
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Nhập mã khách hàng" && textBox3.Text!="Nhập tên khách hàng"&& textBox4.Text!="Nhập số điện thoại"&&textBox5.Text!="Nhập địa chỉ" && comboBox3.GetItemText(comboBox3.SelectedItem) != "")
            {
                DataTable g = KhachHang_DAL.Instance.AddRow(textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text, comboBox3.GetItemText(comboBox3.SelectedItem));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = KhachHang_DAL.Instance.LoadTableList();
                //dataGridView2.FirstDisplayedScrollingRowIndex = g.Rows.Count - 1;
            }
        }
        private void loadtable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[0].DataPropertyName = "idUsernameCustom";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[1].DataPropertyName = "CustomName";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            dataGridView1.Columns[2].DataPropertyName = "Phone";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].DataPropertyName = "Address";
            dataGridView1.Columns[4].HeaderText = "Loại khách hàng";
            dataGridView1.Columns[4].DataPropertyName = "TypeCustom";
            dataGridView1.DataSource= KhachHang_DAL.Instance.LoadTableList();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DataTable g = KhachHang_DAL.Instance.DeleteRow(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = KhachHang_DAL.Instance.LoadTableList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Nhập mã khách hàng" && textBox3.Text != "Nhập tên khách hàng" && textBox4.Text != "Nhập số điện thoại" && textBox5.Text != "Nhập địa chỉ" && comboBox3.GetItemText(comboBox3.SelectedItem) != "")
            {
                DataTable g = KhachHang_DAL.Instance.UpdateRow(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox3.GetItemText(comboBox3.SelectedItem));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = KhachHang_DAL.Instance.LoadTableList();
                //dataGridView2.FirstDisplayedScrollingRowIndex = g.Rows.Count - 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected= true;
            DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
            textBox2.Text = data.Cells[0].Value.ToString();
            textBox3.Text = data.Cells[1].Value.ToString();
            textBox4.Text = data.Cells[2].Value.ToString();
            textBox5.Text = data.Cells[3].Value.ToString();
            comboBox3.SelectedIndex = comboBox3.FindStringExact(data.Cells[4].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gg = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (textBox_TimKiem.Text != "Tìm kiếm")
            {
                if (gg == "Mã khách hàng")
                {
                    DataTable g = KhachHang_DAL.Instance.SearchTable(textBox_TimKiem.Text, "idUsernameCustom");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (gg == "Tên khách hàng")
                {
                    DataTable g = KhachHang_DAL.Instance.SearchTable(textBox_TimKiem.Text, "CustomName");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (gg == "Số điện thoại")
                {
                    DataTable g = KhachHang_DAL.Instance.SearchTable(textBox_TimKiem.Text, "Phone");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (gg == "Địa chỉ")
                {
                    DataTable g = KhachHang_DAL.Instance.SearchTable(textBox_TimKiem.Text, "Address");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
            }
            if (gg == "Loại khách hàng" && comboBox3.GetItemText(comboBox3.SelectedItem) != "")
            {
                DataTable g = KhachHang_DAL.Instance.SearchTable(comboBox3.GetItemText(comboBox3.SelectedItem), "TypeCustom");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = g;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=null;
            dataGridView1.DataSource = KhachHang_DAL.Instance.LoadTableList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboxItem = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (comboxItem == "Loại khách hàng")
            {
                comboBox2.Visible = true;
                textBox_TimKiem.Visible = false;
            }
            else
            {
                comboBox2.Visible = false;
                textBox_TimKiem.Visible = true;
            }
        }
    }
}
