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
using DTO;

namespace FoodStoreManagement
{
    public partial class Form_DSBan : Form
    {
        private int indexrow;
        string SearchPlaceHolder = "Tìm kiếm";
        string InputNamePlaceHolder  = "Nhập tên bàn";
        public Form_DSBan()
        {
            InitializeComponent();
            loadtable();
            
        }

        private void Form_DSBan_Load(object sender, EventArgs e)
        {
            textBox_TimKiem.LostFocus += textBox_TimKiem_LostFocus;
            textBox_TimKiem.GotFocus += textBox_TimKiem_Focus;
            textBox5.LostFocus += textBox5_LostFocus;
            textBox5.GotFocus += textBox5_Focus;
        }

        private void textBox5_Focus(object sender, EventArgs e)
        {
            if (textBox5.Text == InputNamePlaceHolder)
            {
                textBox5.ForeColor = Color.Black;
                textBox5.Text = "";
            }
        }

        private void textBox5_LostFocus(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.ForeColor = Color.Gray;
                textBox5.Text = SearchPlaceHolder;
            }
        }

        private void textBox_TimKiem_LostFocus(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == "")
            {
                textBox_TimKiem.ForeColor = Color.Gray;
                textBox_TimKiem.Text = SearchPlaceHolder;
            }
        }
        private void textBox_TimKiem_Focus(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == SearchPlaceHolder)
            {
                textBox_TimKiem.ForeColor = Color.Black;
                textBox_TimKiem.Text = "";
            }

        }

        private void loadtable()
        {
            dataGridView2.AutoGenerateColumns=false;
            dataGridView2.ColumnCount=3;
            dataGridView2.Columns[0].HeaderText = "Mã số";
            dataGridView2.Columns[0].DataPropertyName="id";
            dataGridView2.Columns[1].HeaderText = "Tên bàn";
            dataGridView2.Columns[1].DataPropertyName = "tablefood";
            dataGridView2.Columns[2].HeaderText = "Trạng thái";
            dataGridView2.Columns[2].DataPropertyName = "status";
            //BindingList<Ban> tableList = Ban_DAL.Instance.LoadTableList();
            dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }
            DataTable g=Ban_DAL.Instance.DeleteRow((int)dataGridView2.SelectedRows[0].Cells[0].Value);
            dataGridView2.DataSource=null;
            dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
            //dataGridView2.FirstDisplayedScrollingRowIndex = g.Rows.Count - 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox5.Text!="Nhập tên bàn" && comboBox1.GetItemText(comboBox1.SelectedItem)!="")
            {
                DataTable g = Ban_DAL.Instance.AddRow(textBox5.Text, comboBox1.GetItemText(comboBox1.SelectedItem));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
                //dataGridView2.FirstDisplayedScrollingRowIndex = g.Rows.Count - 1;
            }
            
            //dataGridView2.FirstDisplayedScrollingRowIndex = BindingSource.Count - 1;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            indexrow  = e.RowIndex;
            DataGridViewRow data = dataGridView2.Rows[indexrow];
            textBox5.Text = data.Cells[1].Value.ToString();
            comboBox1.SelectedIndex = comboBox1.FindStringExact(data.Cells[2].Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "Nhập tên bàn" && comboBox1.GetItemText(comboBox1.SelectedItem) != "")
            {
                DataTable g = Ban_DAL.Instance.UpdateRow(dataGridView2.SelectedRows[0].Cells[0].Value.ToString(), textBox5.Text, comboBox1.GetItemText(comboBox1.SelectedItem));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
                dataGridView2.FirstDisplayedScrollingRowIndex = indexrow;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gg = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (textBox_TimKiem.Text!="Tìm kiếm")
            {
                if (gg == "Mã số")
                {
                    DataTable g = Ban_DAL.Instance.SearchTable(textBox_TimKiem.Text,"id");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = g;
                }
                if(gg=="Tên bàn")
                {
                    DataTable g = Ban_DAL.Instance.SearchTable(textBox_TimKiem.Text,"tablefood");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = g;
                }
            }
            if (gg == "Trạng thái" && comboBox3.GetItemText(comboBox3.SelectedItem) != "")
            {
                DataTable g = Ban_DAL.Instance.SearchTable(comboBox3.GetItemText(comboBox3.SelectedItem), "status");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = g;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboxItem = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (comboxItem == "Trạng thái")
            {
                comboBox3.Visible = true;
                textBox_TimKiem.Visible = false;
            }
            else
            {
                comboBox3.Visible = false;
                textBox_TimKiem.Visible = true;
            }
        }
    }
}
