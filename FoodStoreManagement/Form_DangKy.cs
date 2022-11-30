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
    public partial class Form_DangKy : Form
    {
        Form_DangNhap form1;
        public Form_DangKy()
        {
            InitializeComponent();
        }
        public Form_DangKy(Form_DangNhap form_DangNhap)
        {
            InitializeComponent();
            form1 = form_DangNhap;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_DangKy_FormClosed);
        }
        void Form_DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
                textBox3.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label5.Visible = true;
            }
            else
                label5.Visible = false;
            if (textBox4.Text == "")
            {
                label7.Visible = true;
            }
            else
                label7.Visible = false;
            if(textBox3.Text == "")
            {
                label8.Visible = true;
            }    
            else
                label8.Visible = false;
            if (textBox2.Text == "")
            {
                label9.Visible=true;
            }
            else
                label9.Visible = false;
            if (checkBox1.Checked==false)
            {
                MessageBox.Show("Bạn chưa đồng ý với điều khoản và điều kiện");
            }
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && checkBox1.Checked)
            {
                MessageBox.Show("Tạo tài khoản thành công!");
                form1.Visible=true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.Visible = true;
            this.Close();
        }
    }
}
