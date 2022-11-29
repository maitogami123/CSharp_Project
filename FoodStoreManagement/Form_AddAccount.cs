using FoodStoreManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_AddAccount : Form
    {
        public Form_AddAccount()
        {
            InitializeComponent();
            ClearMessageError();
        }
        public void ClearMessageError()
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label10.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            ClearMessageError();

        }
        public bool validateUserName (string input)
        {
            DataTable dt = new DataTable();
            dt = QuanLyTaiKhoan_DAL.Instance.ValidateAddForm__UserName();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["UserName"].ToString() == input.ToString()) return true;

            }
            return false;
        }
        public bool ValidateTypeAccount(string input)
        { 
            DataTable dt = new DataTable();
            dt = QuanLyTaiKhoan_DAL.Instance.ValidateAddForm__TypeAccount();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["TypeAccount"].ToString() == input.ToString()) return true;
                
            }
            return false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearMessageError();
            bool checkTextBox1 = true;
            bool checkTextBox2 = true;
            bool checkTextBox3 = true;
            bool checkTextBox4 = true;
            bool checkTextBox5 = true;
            if (textBox1.Text.Length < 3 || textBox1.Text == "" || validateUserName(textBox1.Text))
            {
                label5.Show();
                checkTextBox1 = false;
            }
            if (textBox3.Text == null || textBox3.Text == "")
            {
                label6.Show();
                checkTextBox3 = false;
            }
            if (textBox2.Text.Length < 6 || textBox2.Text == "")
            {
                label7.Show();
                checkTextBox2 = false;
            }
            if (textBox4.Text != textBox2.Text) { label8.Show(); checkTextBox4 = false; }
            if (!ValidateTypeAccount(textBox5.Text)){
                label10.Show();
                checkTextBox5 = false;
            }
            if(checkTextBox1 && checkTextBox2&&checkTextBox3 && checkTextBox4 && checkTextBox5)
            {
                QuanLyTaiKhoan_DAL.instance.AddRow(textBox1.Text, textBox3.Text, textBox2.Text, Int32.Parse(textBox5.Text));
                this.Close();
            }
        }
    }
}
