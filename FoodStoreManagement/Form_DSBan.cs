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
        public Form_DSBan()
        {
            InitializeComponent();
            loadtable();
        }

        private void Form_DSBan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void loadtable()
        {
            dataGridView2.AutoGenerateColumns=false;
            dataGridView2.ColumnCount=3;
            dataGridView2.Columns[0].HeaderText = "ID";
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
            Ban_DAL.Instance.DeleteRow((int)dataGridView2.SelectedRows[0].Cells[0].Value);
            dataGridView2.DataSource=null;
            dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
            //dataGridView2.FirstDisplayedScrollingRowIndex = BindingSource.Count - 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ban_DAL.Instance.AddRow(textBox5.Text,comboBox1.GetItemText(comboBox1.SelectedItem));
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Ban_DAL.Instance.LoadTableList();
            //dataGridView2.FirstDisplayedScrollingRowIndex = BindingSource.Count - 1;
        }
    }
}
