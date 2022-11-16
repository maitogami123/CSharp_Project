using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManagement
{
    public partial class Form1 : Form
    {
        string UsernameLogin="u";
        string PasswordLogin="1";
        string UsernamePlaceHolder = "Enter Your Username";
        string PasswordPlaceHolder = "Enter Your Password";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Select();
            UsernameTextBox.LostFocus += UsernameTextBox_LostFocus;
            UsernameTextBox.GotFocus += UsernameTextBox_Focus;
            PasswordTextBox.LostFocus += PasswordTextBox_LostFocus;
            PasswordTextBox.GotFocus += PasswordTextBox_Focus;

        }
        private void UsernameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.ForeColor = Color.Gray;
                UsernameTextBox.Text = UsernamePlaceHolder;
            }
        }
        private void UsernameTextBox_Focus(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == UsernamePlaceHolder)
            {
                UsernameTextBox.ForeColor = Color.Black;
                UsernameTextBox.Text = "";
            }
        }
        private void PasswordTextBox_LostFocus(object sender, EventArgs e)
        {
            if(PasswordTextBox.Text == "")
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.ForeColor = Color.Gray;
                PasswordTextBox.Text = PasswordPlaceHolder;
            }
        }
        private void PasswordTextBox_Focus(object sender, EventArgs e)
        {
            if(PasswordTextBox.Text == PasswordPlaceHolder)
            {
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.Text = ""; 
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text != PasswordPlaceHolder)
            {
                if (checkBox1.Checked)
                {
                    PasswordTextBox.UseSystemPasswordChar = false;
                }
                else
                    PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PasswordTextBox.Text!=PasswordPlaceHolder)
            {
                PasswordTextBox.ForeColor = Color.Gray;
                PasswordTextBox.Text = PasswordPlaceHolder;
            }
            if(UsernameTextBox.Text!=UsernamePlaceHolder)
            {
                UsernameTextBox.ForeColor = Color.Gray;
                UsernameTextBox.Text = UsernamePlaceHolder;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == UsernamePlaceHolder)
            {
                label6.Visible = true;
            }
            else
                label6.Visible = false;
            if (PasswordTextBox.Text == PasswordPlaceHolder)
            {
                label7.Text = "Nhập mật khẩu!";
                label7.Visible = true;
            }
            else
                label7.Visible = false;
            if (UsernameTextBox.Text != UsernamePlaceHolder && PasswordTextBox.Text != PasswordPlaceHolder)
            {
                if (UsernameTextBox.Text == UsernameLogin && PasswordTextBox.Text == PasswordLogin)
                {
                    Form3 frm = new Form3();
                    frm.Show();
                    this.Visible = false;
                }
                else
                    label7.Text = "Nhập sai tên tài khoản hoặc mật khẩu";
                    label7.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Visible = false;
        }
    }
}
