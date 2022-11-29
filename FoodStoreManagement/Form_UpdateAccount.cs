using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodStoreManagement.DAL;

namespace FoodStoreManagement.GUI
{
    public partial class Form_UpdateAccount : Form
    {
        public Form_UpdateAccount(string userName, string displayUserName, string passWord, string typeAccount)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            textBox1.Text = userName;
            textBox3.Text = displayUserName;
            textBox2.Text = passWord;
            comboBox1.Text = typeAccount;
            ClearMessageError();
        }
        public void ClearMessageError()
        {
            label6.Hide();
            label7.Hide();
            label10.Hide();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearMessageError();
            bool checkTextBox2 = true;
            bool checkTextBox3 = true;
            bool checkTextBox5 = true;
            
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
            
            if (!ValidateTypeAccount(comboBox1.GetItemText(comboBox1.SelectedItem)))
            {
                label10.Show();
                checkTextBox5 = false;
            }
            if (checkTextBox2 && checkTextBox3 &&  checkTextBox5)
            {
                QuanLyTaiKhoan_DAL.instance.UpdateRow(textBox1.Text, textBox3.Text, textBox2.Text, Int32.Parse(comboBox1.Text));
                this.Close();
            }
        }

        private void Form_UpdateAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodStore_ManagermentDataSet1.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.foodStore_ManagermentDataSet1.Account);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = comboBox1.Enabled.ToString();
        }
    }
}
