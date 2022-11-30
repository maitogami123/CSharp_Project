using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_Kho : Form
    {
        public Form_Kho()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        private void Form_Kho_Load(object sender, EventArgs e)
        {
            //this.FormClosed += new FormClosedEventHandler(Form_FormClosed);\
            dataGridView1.DataSource = dataBUS.getData();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
        //public void Header()
        //{

        //    listView1.Columns.Add("Mã nguyên liệu");
        //    listView1.Columns.Add("Tình trạng");
        //    listView1.Columns.Add("Ngày nhập");
        //    listView1.Columns.Add("Số lượng");
        //    listView1.Columns.Add("Mã nhân viên");
        //    listView1.View = View.Details;
        //}
        WarehouseIngredientBUS dataBUS = new WarehouseIngredientBUS();
        //public void show()
        //{
        //    DataTable data = new DataTable();
        //    data = dataBUS.getData();
        //    for (int i = 0; i < data.Rows.Count; i++)
        //    {
        //        DataRow dataRow = data.Rows[i];
        //        ListViewItem item = new ListViewItem(dataRow[0].ToString());
        //        ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dataRow[0].ToString());
        //        item.SubItems.Add(dataRow[1].ToString());
        //        item.SubItems.Add(dataRow[2].ToString());
        //        item.SubItems.Add(dataRow[3].ToString());
        //        item.SubItems.Add(dataRow[4].ToString());
        //        listView1.Items.Add(item);
        //    }
        //    listView1.View = View.Details;
        //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //}



        private void button8_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt16(textBox2.Text);
            string status = textBox3.Text;
            DateTime time = Convert.ToDateTime(dateTimePicker_Date.Text);
            string idRequireAdd = textBox6.Text;
            string idStaff = comboBox3.Text;
            WarehouseIngredientDTO warehouseIngredientDTO = new WarehouseIngredientDTO(idFood, status, time, idRequireAdd, idStaff);

            dataBUS.insertData(warehouseIngredientDTO);
            dataGridView1.DataSource = dataBUS.getData();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int idFood = Convert.ToInt16(row.Cells[0].Value.ToString());
                WarehouseIngredientDTO warehouseIngredientDTO = new WarehouseIngredientDTO
                    (idFood, textBox3.Text, Convert.ToDateTime(dateTimePicker_Date.Text), textBox6.Text, comboBox3.Text); ;
                dataBUS.updateData(warehouseIngredientDTO);
                dataGridView1.DataSource = dataBUS.getData();
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt16(row.Cells[0].Value.ToString());
                dataBUS.delData(id);
                dataGridView1.DataSource = dataBUS.getData();
            }
        }
    }
}
