using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_Kho : Form
    {
        public Form_Kho()
        {
            InitializeComponent();
            
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
            string status = textBox3.Text;
            string idRequireAdd = textBox6.Text;
            string idStafftoAddWarehouse = comboBox3.Text;
            if (textBox3.Text != "" && textBox2.Text != "" && textBox6.Text != "")
            {
                int id = Convert.ToInt32(textBox2.Text);
                DateTime time = Convert.ToDateTime(dateTimePicker_Date.Text);
                WarehouseIngredientDTO dataDTO = new WarehouseIngredientDTO(id, status, time, idRequireAdd, idStafftoAddWarehouse);
                if (dataBUS.insertData(dataDTO))
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Nhập thông tin");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string status = textBox3.Text;
                string idRequireAdd = textBox6.Text;
                string idStafftoAddWarehouse = comboBox3.Text;
                DateTime time = Convert.ToDateTime(dateTimePicker_Date.Text);
                ListViewItem item = listView1.SelectedItems[0];
                int id = Convert.ToInt32(textBox2.Text);

                WarehouseIngredientDTO dataDTO = new WarehouseIngredientDTO(id, status, time, idRequireAdd, idStafftoAddWarehouse);
                if(dataBUS.updateData(dataDTO))
                {
                    MessageBox.Show("Thành Công");
                    listView1.Show();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng");
            }
        }
    }
}
