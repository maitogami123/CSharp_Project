using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManagement.Form_Add
{
    public partial class Form_UpdateDatBan : Form
    {
        private string PlaceHolder1 = "Nhập số người";
        private string PlaceHolder2 = "Nhập mã đặt bàn";
        private int id;
        public Form_UpdateDatBan()
        {
            InitializeComponent();
            dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            //dateTimePicker_Time.CustomFormat = "HH:mm:ss";
            dateTimePicker_Time.ShowUpDown = true;
            dateTimePicker_Time.Value = DateTime.Now;
            dateTimePicker_Date.MinDate = DateTime.Today;
            dateTimePicker_Date.MaxDate = DateTime.Today.AddDays(7);
            loadcombox();
        }
        public Form_UpdateDatBan(int id)
        {
            InitializeComponent();
            this.id = id;
            dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            //dateTimePicker_Time.CustomFormat = "HH:mm:ss";
            dateTimePicker_Time.ShowUpDown = true;
            dateTimePicker_Time.Value = DateTime.Now;
            dateTimePicker_Date.MinDate = DateTime.Today;
            dateTimePicker_Date.MaxDate = DateTime.Today.AddDays(7);
            loadcombox();
            BringInfo();
        }

        private void Form_UpdateDatBan_Load(object sender, EventArgs e)
        {
            textBox4.LostFocus += textBox_LostFocus;
            textBox1.LostFocus += textBox_LostFocus;
            textBox4.GotFocus += textBox_Focus;
            textBox1.GotFocus += textBox_Focus;
        }
        private void textBox_LostFocus(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = PlaceHolder1;
                textBox4.ForeColor = Color.Gray;
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = PlaceHolder2;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox_Focus(object sender, EventArgs e)
        {
            if (textBox4.Text == PlaceHolder1)
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
            if (textBox1.Text == PlaceHolder2)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void loadcombox()
        {
            comboBox3.DisplayMember = "id";
            comboBox3.ValueMember = "id";
            comboBox3.DataSource = DatBan_DAL.Instance.GetidBan();

            comboBox1.DisplayMember = "idUsernameCustom";
            comboBox1.ValueMember = "idUsernameCustom";
            comboBox1.DataSource = DatBan_DAL.Instance.GetidKH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = PlaceHolder1;
            textBox4.ForeColor = Color.Gray;
            textBox1.Text = PlaceHolder2;
            textBox1.ForeColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Nhập số người")
            {
                return;
            }
            if (!int.TryParse(textBox4.Text, out int right) || !int.TryParse(textBox1.Text, out int gg))
            {
                return;
            }
            DatBan_DAL.Instance.UpdateRow(int.Parse(textBox1.Text), int.Parse(comboBox3.GetItemText(comboBox3.SelectedItem)), comboBox1.GetItemText(comboBox1.SelectedItem), dateTimePicker_Time.Value.TimeOfDay.ToString(), dateTimePicker_Date.Value.Date.ToString("yyyy-MM-dd"), int.Parse(textBox4.Text));
            this.Close();
        }
        private void BringInfo()
        {
            DataTable data = DatBan_DAL.Instance.SearchTable(id.ToString(), "idDatBan");
            DataTable DSidBan = DatBan_DAL.Instance.GetidBan();
            DataTable DSidKH = DatBan_DAL.Instance.GetidKH();

            dateTimePicker_Time.Value = DateTime.Parse(data.Rows[0]["ThoiGian"].ToString());
            dateTimePicker_Date.Value = DateTime.Parse(data.Rows[0]["Ngay"].ToString());
            comboBox3.SelectedValue = data.Rows[0]["idBan"];
            comboBox1.SelectedValue = data.Rows[0]["idKH"];
            //for (int i = 0; i < DSidBan.Rows.Count; i++)
            //    {
            //        if (DSidBan.Rows[i]["id"] == data.Rows[0]["idBan"])
            //        {
            //            comboBox3.SelectedValue = DSidBan.Rows[i]["id"];
            //        }
            //    }
            //for (int i = 0; i < DSidKH.Rows.Count; i++)
            //    {
            //        if (DSidKH.Rows[i]["idUsernameCustom"] == data.Rows[0]["idKH"])
            //        {
            //            comboBox1.SelectedValue = DSidKH.Rows[i]["idUsernameCustom"];
            //        }
            //    }
            //comboBox1.SelectedItem = comboBox1.FindStringExact(data.Cells[1].Value.ToString());
            //comboBox1.SelectedItem = 3;
            textBox1.Text = data.Rows[0]["idDatBan"].ToString();
            textBox4.Text = data.Rows[0]["SoNguoi"].ToString();
        }
    }
}
