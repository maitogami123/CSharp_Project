using FoodStoreManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_DSMonAn : Form
    {
        public Form_DSMonAn()
        {
            InitializeComponent();
            loadtable();
        }
        void loadtable()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].HeaderText = "Mã số";
            dataGridView2.Columns[0].DataPropertyName = "id";
            dataGridView2.Columns[1].HeaderText = "foodName";
            dataGridView2.Columns[1].DataPropertyName = "FoodName";
            dataGridView2.Columns[2].HeaderText = "Mã thể loại";
            dataGridView2.Columns[2].DataPropertyName = "idCategoryFood";
            dataGridView2.Columns[3].HeaderText = "Giá tiền";
            dataGridView2.Columns[3].DataPropertyName = "Price";
            
            dataGridView2.DataSource = FoodList_DAL.Instance.LoadTableList();
        }
       
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
        //Insert
        private void button3_Click(object sender, EventArgs e)
        {
            Form_AddFood addFood = new Form_AddFood();
            addFood.Show();
        }


        //Update
        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentCell.OwningRow;
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            string foodName = row.Cells[1].Value.ToString();
            int idCategory = Int32.Parse(row.Cells[2].Value.ToString());
            float price = float.Parse(row.Cells[3].Value.ToString());
            Form_UpdateFood updateForm = new Form_UpdateFood(id,foodName,idCategory,price);
            
            updateForm.Show();
        }


        //Delete
        private void button6_Click(object sender, EventArgs e)
        { 
            FoodList_DAL.Instance.DeleteRow((int)this.dataGridView2.SelectedRows[0].Cells[0].Value);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = FoodList_DAL.Instance.LoadTableList();
        }

        //Filter
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == comboBox4.FindStringExact("Lọc theo giá từ cao đến thấp"))
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = FoodList_DAL.Instance.FilterPriceASC();
            }
            else if (comboBox4.SelectedIndex == comboBox4.FindStringExact("Lọc theo giá từ thấp đến cao"))
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = FoodList_DAL.Instance.FilterPriceDESC();
            }
            else if (comboBox4.SelectedIndex == comboBox4.FindStringExact("Lọc theo tên từ A đến Z"))
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = FoodList_DAL.Instance.FilterFoodNameASC();
            }
            else if (comboBox4.SelectedIndex == comboBox4.FindStringExact("Lọc theo tên từ Z đến A"))
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = FoodList_DAL.Instance.FilterFoodNameDESC();
            }
            else
            {
                return;
            }
        }
        
        //Reset
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = FoodList_DAL.Instance.LoadTableList();
        }
        //Search
        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FoodList_DAL.Instance.SearchFoodName(textBox2.Text);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = FoodList_DAL.Instance.SearchFoodName(textBox2.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_DSMonAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodStore_ManagermentDataSet.CategoryFood' table. You can move, or remove it, as needed.
            this.categoryFoodTableAdapter.Fill(this.foodStore_ManagermentDataSet.CategoryFood);

        }

        
    }
}
