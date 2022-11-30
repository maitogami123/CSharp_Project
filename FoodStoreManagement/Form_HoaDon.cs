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
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            loadtable();
        }
        void loadtable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].HeaderText = "Mã số";
            dataGridView1.Columns[0].DataPropertyName = "id";
            dataGridView1.Columns[1].HeaderText = "Ngày Nhập";
            dataGridView1.Columns[1].DataPropertyName = "DayIn";
            dataGridView1.Columns[2].HeaderText = "Ngày xuất";
            dataGridView1.Columns[2].DataPropertyName = "DayOut";
            dataGridView1.Columns[3].HeaderText = "Mã bàn";
            dataGridView1.Columns[3].DataPropertyName = "idTableFood";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[4].DataPropertyName = "TotalPrice";
            dataGridView1.Columns[5].HeaderText = "Trạng thái";
            dataGridView1.Columns[5].DataPropertyName = "status";
            dataGridView1.Columns[6].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[6].DataPropertyName = "idStaff";
            dataGridView1.DataSource = Bill_DAL.Instance.LoadTableList();
        }
        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string comboBoxItem = comboBox3.GetItemText(comboBox3.SelectedItem);
            if (textBox5.Text != "Tìm kiếm")
            {
                if (comboBoxItem == "Mã nhân viên")
                {
                    DataTable g = Bill_DAL.Instance.SearchTable(textBox5.Text, "idStaff");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (comboBoxItem == "Giá tiền")
                {
                    DataTable g = Bill_DAL.Instance.SearchTable(textBox5.Text, "TotalPrice");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (comboBoxItem == "Ngày nhập")
                {
                    DataTable g = Bill_DAL.Instance.SearchTable(textBox5.Text, "DayIn");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (comboBoxItem == "Trạng thái")
                {
                    DataTable g = Bill_DAL.Instance.SearchTable(textBox5.Text, "status");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }
                if (comboBoxItem == "Mã bàn")
                {
                    DataTable g = Bill_DAL.Instance.SearchTable(textBox5.Text, "idTableFood");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = g;
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Bill_DAL.Instance.LoadTableList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadtable2();
            
        }
        void loadtable2()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].HeaderText = "Mã số";
            dataGridView2.Columns[0].DataPropertyName = "id";
            dataGridView2.Columns[1].HeaderText = "Mã số hóa đớn";
            dataGridView2.Columns[1].DataPropertyName = "idBill";
            dataGridView2.Columns[2].HeaderText = "Mã thức ăn";
            dataGridView2.Columns[2].DataPropertyName = "idFood";
            dataGridView2.Columns[3].HeaderText = "Số lượng";
            dataGridView2.Columns[3].DataPropertyName = "AmountFood";
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill =N'"+ row.Cells[0].Value.ToString() + "'");
        }
    }
}
