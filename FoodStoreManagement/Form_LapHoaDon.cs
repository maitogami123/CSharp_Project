using FoodStoreManagement.DAL;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace FoodStoreManagement.GUI
{
    public partial class Form_LapHoaDon : Form
    {
        private DataGridViewRow row1;
        private DataGridViewRow row2;
        public Form_LapHoaDon()
        {
            InitializeComponent();
            loadtable();
            loadcombox();
        }

        private void Form_LapHoaDon_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
        void loadtable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "Mã món ăn";
            dataGridView1.Columns[0].DataPropertyName = "idFood";
            dataGridView1.Columns[1].HeaderText = "Tên món ăn";
            dataGridView1.Columns[1].DataPropertyName= "FoodName";
            dataGridView1.Columns[2].HeaderText = "Giá/1 món";
            dataGridView1.Columns[2].DataPropertyName = "Price";
            dataGridView1.Columns[3].HeaderText = "Số lượng";
            dataGridView1.Columns[3].DataPropertyName = "AmountFood";
            

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
        private void loadcombox()
        {
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = HoaDon_LapHD_DAL.Instance.GetidBan();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            row2 = dataGridView2.Rows[e.RowIndex];
            numericUpDown2.Value = 1;
            //dataGridView1.ClearSelection();
            //button5.Visible = true;
            //button6.Visible = false;
            //button7.Visible = false;
        }
        private DataTable SortBillInfo(string id)
        {
            DataTable gh = CTHD_LapHD_DAL.Instance.LoadBillInfo();
            //DataTable ff = CTHD_DAL.Instance.LoadTableWithID(id);
            DataTable hh = new DataTable();
            hh=gh.Clone();
            hh.Rows.Clear();
            //if(gh.Rows)
            //    hh.Rows.Add(gh.Select("idBill="+id));
            foreach(DataRow row in gh.Rows)
            {
                if (row["idBill"].ToString()==id)
                {
                    hh.ImportRow(row);
                }    
            }    
            return hh;
        }
        private string FindIdBill()
        {
            DataTable g = HoaDon_LapHD_DAL.Instance.GetTableStatus(comboBox1.GetItemText(comboBox1.SelectedItem));
            string idf = g.Rows[0]["id"].ToString();
            DataTable f = HoaDon_LapHD_DAL.Instance.LoadId(idf, "idTableFood", "0");
            foreach (DataRow row in f.Rows)
            {
                if (row["idTableFood"].ToString() == idf)
                {
                    return row["id"].ToString();
                }
            }
            return "";
        }
        private bool CheckFoodInCTHD()
        {
            DataTable b = CTHD_LapHD_DAL.Instance.SearchTable(FindIdBill(),"idBill");
            //if((int)dataGridView1.SelectedRows[0].Cells[0].Value !=)
            if(b.Rows.Count==0)
            {
                return false;
            }    
            foreach(DataRow dataRow in b.Rows)
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value.ToString() == dataRow["idFood"].ToString())
                {
                    return true;
                }    
            }
            return false;
        }
        private string TongTien()
        {
            float f=0;
            foreach(DataGridViewRow g in dataGridView1.Rows)
            {
                f += float.Parse(g.Cells[2].Value.ToString())* float.Parse(g.Cells[3].Value.ToString());
            }
            return f.ToString();
        }
        private string TienDu()
        {
            float f = 0;
            if (!int.TryParse(textBox4.Text, out int right))
            {
                float g=0- float.Parse(TongTien());
                return g.ToString();
            }
            foreach (DataGridViewRow g in dataGridView1.Rows)
            {
                f = float.Parse(textBox4.Text) - float.Parse(TongTien());
            }
            return f.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable g = HoaDon_LapHD_DAL.Instance.GetTableStatus(comboBox1.GetItemText(comboBox1.SelectedItem));
            string status = g.Rows[0]["status"].ToString();
            string idf = g.Rows[0]["id"].ToString();
            if (status=="Trống")
            {
                HoaDon_LapHD_DAL.Instance.ChangeTableStatus(idf, "Có người");
                HoaDon_LapHD_DAL.Instance.AddRow(idf, "NV-1", DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Today.ToString("yyyy-MM-dd"), "0", 0);
                dataGridView1.DataSource = null;
                DataTable gh = SortBillInfo(FindIdBill());
                dataGridView1.DataSource = gh;
                textBox1.Text = TongTien();
                textBox3.Text = TienDu();
            }
            if (status == "Có người")
            {
                DataTable f = HoaDon_LapHD_DAL.Instance.LoadId(idf,"idTableFood","0");
                foreach(DataRow row in f.Rows)
                {
                    if (row["idTableFood"].ToString()==idf)
                    {
                        
                        dataGridView1.DataSource = null;
                        DataTable gh = SortBillInfo(row["id"].ToString());
                        dataGridView1.DataSource= gh;
                        textBox1.Text=TongTien();
                        textBox3.Text=TienDu();
                        //MessageBox.Show("fsdf");
                        //gh.Columns.Remove("idBill");
                        //gh.Columns.Remove("idFood");
                        //gh.Columns.Remove("idCategoryFood");
                        //gh.Columns.Remove("id");
                    }    
                }
                //f.Columns.Remove("id");
                //f.Select("");
                //HoaDon_DAL.Instance.ChangeTableStatus(g.Rows[0]["id"].ToString(), "Có người");
                //HoaDon_DAL.Instance.AddRow(g.Rows[0]["id"].ToString(), "idNV", DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Today.ToString("yyyy-MM-dd"), "chưa thanh toán", 0);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CurrentRow.Selected = true;
            //row1 = dataGridView1.Rows[e.RowIndex];
            //dataGridView2.ClearSelection();
            //button5.Visible=false;
            //button6.Visible = true;
            //button7.Visible = true;
            //numericUpDown1.Value = (int)row1.Cells[3].Value;
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                return;
            }
            if (dataGridView1.SelectedRows.Count > 1 || dataGridView1.SelectedRows.Count <=0)
            {
                return;
            }
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataTable g = CTHD_LapHD_DAL.Instance.UpdateRow(FindIdBill(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), (int)numericUpDown1.Value);
                dataGridView1.DataSource = null;
                //dataGridView1.DataSource = g;
                //MessageBox.Show(row1.Cells[0].Value.ToString());
                dataGridView1.DataSource = SortBillInfo(FindIdBill());
                textBox1.Text = TongTien();
                textBox3.Text = TienDu();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                return;
            }
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataTable g = CTHD_LapHD_DAL.Instance.DeleteRow(FindIdBill(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = null;
                //dataGridView1.DataSource = g;
                dataGridView1.DataSource = SortBillInfo(FindIdBill());
                textBox1.Text = TongTien();
                textBox3.Text = TienDu();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                return;
            }
            if (!int.TryParse(textBox4.Text, out int right))
            {
                return;
            }
            textBox3.Text = TienDu();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(float.Parse(textBox3.Text)<0)
            {
                return;
            }
            DataTable g = HoaDon_LapHD_DAL.Instance.GetTableStatus(comboBox1.GetItemText(comboBox1.SelectedItem));
            string idf = g.Rows[0]["id"].ToString();
            HoaDon_LapHD_DAL.Instance.ChangeTableStatus(idf, "Trống");
            HoaDon_LapHD_DAL.Instance.UpdateHDStatusAndMoney(FindIdBill(),idf, "NV-1", "1",textBox1.Text);
            dataGridView1.DataSource = null;
            textBox1.Text = "0";
            textBox3.Text= "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                return;
            }
            if (dataGridView2.CurrentRow.Selected == true && CheckFoodInCTHD() == false)
            {

                DataTable g = CTHD_LapHD_DAL.Instance.AddRow(FindIdBill(), dataGridView2.CurrentRow.Cells[0].Value.ToString(), (int)numericUpDown2.Value);
                dataGridView1.DataSource = null;

                //dataGridView1.DataSource = g;
                dataGridView1.DataSource = SortBillInfo(FindIdBill());
                textBox1.Text = TongTien();
                textBox3.Text = TienDu();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //row1 = dataGridView1.Rows[e.RowIndex];
            numericUpDown1.Value = (int)dataGridView1.CurrentRow.Cells[3].Value;

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SortBillInfo(FindIdBill());
        }
    }
}
