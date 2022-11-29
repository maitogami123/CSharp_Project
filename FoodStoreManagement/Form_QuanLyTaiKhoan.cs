using FoodStoreManagement.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_QuanLyTaiKhoan : Form
    {
        string searchPlaceholder = "Tìm kiếm";

        public Form_QuanLyTaiKhoan()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            LoadTable();
            textBox1.LostFocus += TextBox1_LostFocus;
            textBox1.GotFocus += TextBox1_GotFocus;
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == searchPlaceholder)
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = searchPlaceholder;
            }
        }

        void LoadTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "User Name";
            dataGridView1.Columns[0].DataPropertyName = "UserName";
            dataGridView1.Columns[1].HeaderText = "Tên hiển thị";
            dataGridView1.Columns[1].DataPropertyName = "DisplayUserName";
            dataGridView1.Columns[2].HeaderText = "PassWord";
            dataGridView1.Columns[2].DataPropertyName = "PassWord";
            dataGridView1.Columns[3].HeaderText = "Id của chức vụ";
            dataGridView1.Columns[3].DataPropertyName = "TypeAccount";

            dataGridView1.DataSource = QuanLyTaiKhoan_DAL.Instance.LoadTableList();
        }
        private void Form_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comboBoxItem = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (textBox1.Text != "Tìm kiếm")
            {
                if (comboBoxItem == "User Name")
                {
                    DataTable g = QuanLyTaiKhoan_DAL.Instance.SearchTable(textBox1.Text, "UserName");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (comboBoxItem == "Tên của nhân viên")
                {
                    DataTable g = QuanLyTaiKhoan_DAL.Instance.SearchTable(textBox1.Text, "DisplayUserName");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (comboBoxItem == "Chức vụ")
                {
                    DataTable g = QuanLyTaiKhoan_DAL.Instance.SearchTable(textBox1.Text, "TypeAccount");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
            }
        }

        //Delete
        private void Delete_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan_DAL.Instance.DeleteRow(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = QuanLyTaiKhoan_DAL.Instance.LoadTableList();
        }
        //Insert
        private void button5_Click(object sender, EventArgs e)
        {
            Form_AddAccount addAccount = new Form_AddAccount();
            addAccount.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = QuanLyTaiKhoan_DAL.Instance.LoadTableList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string userName = row.Cells[0].Value.ToString();
            string displayUserName = row.Cells[1].Value.ToString();
            string passWord = row.Cells[2].Value.ToString();
            string typeAccount = row.Cells[3].Value.ToString();
            Form_UpdateAccount updateForm = new Form_UpdateAccount(userName, displayUserName, passWord, typeAccount);

            updateForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            DataTable dt = new DataTable();
            if (row.Cells[3].Value.ToString() == "3")
            {
                comboBox2.Show();
                label4.Show();
                dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Customer WHERE idUsernameCustom = N'" + row.Cells[0].Value.ToString() + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox2.Text = dr["idUsernameCustom"].ToString();
                    textBox4.Text = dr["CustomName"].ToString();
                    textBox6.Text = dr["Phone"].ToString();
                    textBox5.Text = dr["Address"].ToString();
                    comboBox2.Text = dr["TypeCustom"].ToString();
                }
                
            }
            else
            {
                dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Staff WHERE idStaff = N'" + row.Cells[0].Value.ToString() + "'");
                foreach (DataRow dr in dt.Rows)
                {
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox2.Text = dr["idStaff"].ToString();
                    textBox4.Text = dr["StaffName"].ToString();
                    textBox6.Text = dr["Phone"].ToString();
                    textBox5.Text = dr["Address"].ToString();
                }
                comboBox2.Hide();
                label4.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == "3")
            {
                QuanLyTaiKhoan_DAL.instance.UpdateRowCustomer(textBox2.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox2.Text);
                MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QuanLyTaiKhoan_DAL.instance.UpdateRowStaff(textBox2.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
