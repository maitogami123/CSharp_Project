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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "Mã số";
            dataGridView1.Columns[0].DataPropertyName = "id";
            dataGridView1.Columns[1].HeaderText = "foodName";
            dataGridView1.Columns[1].DataPropertyName = "FoodName";
            dataGridView1.Columns[2].HeaderText = "Mã thể loại";
            dataGridView1.Columns[2].DataPropertyName = "idCategoryFood";
            dataGridView1.Columns[3].HeaderText = "Giá tiền";
            dataGridView1.Columns[3].DataPropertyName = "Price";
            //BindingList<Ban> tableList = Ban_DAL.Instance.LoadTableList();
            dataGridView1.DataSource = FoodList_DAL.Instance.LoadTableList();
        }
        private void Form_DatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodStore_ManagermentDataSet.CategoryFood' table. You can move, or remove it, as needed.
            //this.categoryFoodTableAdapter.Fill(this.foodStore_ManagermentDataSet.CategoryFood);
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            /*ImageList images = new ImageList();
            images.ImageSize = new Size(150, 120);
            for (int i = 0; i < 5; i++)
            {
                images.Images.Add(Image.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));
            }
            //listView1.LargeImageList = images;
            listView1.LargeImageList = images;

            for (int itemIndex = 1; itemIndex <= 5; itemIndex++)
            {
                //listView1.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
                listView1.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
            }*/
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        


        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
            Form_AddFood addFood = new Form_AddFood();
            addFood.Show();
        }


        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            string foodName = row.Cells[1].Value.ToString();
            int idCategory = Int32.Parse(row.Cells[2].Value.ToString());
            float price = float.Parse(row.Cells[3].Value.ToString());
            Form_UpdateFood updateForm = new Form_UpdateFood(id,foodName,idCategory,price);
            
            updateForm.Show();
        }


        //Delete
        private void button4_Click(object sender, EventArgs e)
        { 
            FoodList_DAL.Instance.DeleteRow((int)this.dataGridView1.SelectedRows[0].Cells[0].Value);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FoodList_DAL.Instance.LoadTableList();
        }

        //Filter
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == comboBox3.FindStringExact("Lọc theo giá từ cao tới thấp"))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FoodList_DAL.Instance.FilterPriceASC();
            }
            else if (comboBox3.SelectedIndex == comboBox3.FindStringExact("Lọc theo giá từ thấp tới cao"))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FoodList_DAL.Instance.FilterPriceDESC();
            }
            else if (comboBox3.SelectedIndex == comboBox3.FindStringExact("Lọc theo tên từ A đến Z"))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FoodList_DAL.Instance.FilterFoodNameASC();
            }
            else if (comboBox3.SelectedIndex == comboBox3.FindStringExact("Lọc theo tền từ Z đến A"))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FoodList_DAL.Instance.FilterFoodNameDESC();
            }
            else
            {
                return;
            }
        }
        
        //Reset
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FoodList_DAL.Instance.LoadTableList();
        }
        //Search
        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FoodList_DAL.Instance.SearchFoodName(textBox2.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FoodList_DAL.Instance.SearchFoodName(textBox2.Text);
            }
        }
    }
}
