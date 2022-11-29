using DAL;
using FoodStoreManagement.DAL;
using FoodStoreManagement.Form_Add;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodStoreManagement.GUI
{
    public partial class Form_DSDatBan : Form
    {
        public static int iddatban;
        private DataGridViewRow row;
        string SearchPlaceHolder = "Tìm kiếm";
        public Form_DSDatBan()
        {
            InitializeComponent();
            //dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            ////dateTimePicker_Time.CustomFormat = "HH:mm:ss";
            //dateTimePicker_Time.ShowUpDown= true;
            //dateTimePicker_Time.Value= DateTime.Now;
            //dateTimePicker1.Format=DateTimePickerFormat.Time;
            //dateTimePicker1.ShowUpDown= true;
            //dateTimePicker1.Value= DateTime.Now;
            ////dateTimePicker_Date.CustomFormat = "yyyy-mm-dd";
            //dateTimePicker_Date.MinDate= DateTime.Today;
            //dateTimePicker_Date.MaxDate = DateTime.Today.AddDays(7);
            loadtable();
            loadcombox();
        }

        private void Form_Ban_Load(object sender, EventArgs e)
        {
            textBox_TimKiem.LostFocus += textBox_LostFocus;
            textBox_TimKiem.GotFocus += textBox_Focus;
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            //textBox_TimKiem.Text = "";
            loadcombox();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible= false;
            //throw new NotImplementedException();
        }

        private void textBox_LostFocus(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == "")
            {
                textBox_TimKiem.ForeColor = Color.Gray;
                textBox_TimKiem.Text = SearchPlaceHolder;
            }
        }
        private void textBox_Focus(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == SearchPlaceHolder)
            {
                textBox_TimKiem.ForeColor = Color.Black;
                textBox_TimKiem.Text = "";
            }
            
        }
        private void loadtable()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].HeaderText = "Mã đặt bàn";
            dataGridView2.Columns[0].DataPropertyName= "idDatBan";
            dataGridView2.Columns[1].HeaderText = "Mã khách hàng";
            dataGridView2.Columns[1].DataPropertyName = "idKH";
            dataGridView2.Columns[2].HeaderText = "Mã bàn";
            dataGridView2.Columns[2].DataPropertyName = "idBan";
            dataGridView2.Columns[3].HeaderText = "Thời gian đặt bàn";
            dataGridView2.Columns[3].DataPropertyName = "ThoiGian";
            dataGridView2.Columns[4].HeaderText = "Ngày đặt bàn";
            dataGridView2.Columns[4].DataPropertyName = "Ngay";
            dataGridView2.Columns[5].HeaderText = "Số người";
            dataGridView2.Columns[5].DataPropertyName = "SoNguoi";
            //BindingList<Ban> tableList = Ban_DAL.Instance.LoadTableList();
            //DataTable h = DatBan_DAL.Instance.LoadTableList();
            //for(int i=0; i<h.Rows.Count;i++)
            //{
            //    if (DateTime.Parse(h.Rows[i]["Ngay"].ToString())<DateTime.Today)
            //    {
            //        DatBan_DAL.Instance.DeleteRow(h.Rows[i]["idDatBan"].ToString());
            //    }    
            //}
            dataGridView2.DataSource = DatBan_DAL.Instance.LoadTableList();
        }
        private void loadcombox()
        {
            //comboBox3.DisplayMember = "id";
            //comboBox3.ValueMember = "id";
            //comboBox3.DataSource = DatBan_DAL.Instance.GetidBan();

            //comboBox1.DisplayMember = "idUsernameCustom";
            //comboBox1.ValueMember = "idUsernameCustom";
            //comboBox1.DataSource = DatBan_DAL.Instance.GetidKH();
            
            comboBox4.DisplayMember= "idDatBan";
            comboBox4.ValueMember = "idDatBan";
            comboBox4.DataSource = RemoveDuplicateRows(DatBan_DAL.Instance.GetColumnTableDatBan("idDatBan"),"idDatBan");

            comboBox5.DisplayMember = "idKH";
            comboBox5.ValueMember = "idKH";
            comboBox5.DataSource = RemoveDuplicateRows(DatBan_DAL.Instance.GetColumnTableDatBan("idKH"), "idKH");

            comboBox6.DisplayMember = "idBan";
            comboBox6.ValueMember = "idBan";
            comboBox6.DataSource = RemoveDuplicateRows(DatBan_DAL.Instance.GetColumnTableDatBan("idBan"), "idBan");
        }

        public DataTable RemoveDuplicateRows(DataTable dt, string colName)
        {
            Hashtable hashtable= new Hashtable();
            DataTable dup = new DataTable();
            dup.Columns.Add(colName);
            foreach(DataRow dataRow in dt.Rows) 
            {
                if (hashtable.Contains(dataRow[colName])==false)
                {
                    hashtable.Add(dataRow[colName], string.Empty);
                    dup.Rows.Add(dataRow[colName]);
                }
            }
            //foreach (DataRow dataRow in dup.Rows)
            //{ 
            //    dt.Rows.Remove(dataRow);
            //}
            return dup;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 1)
            {
                return;
            }

            if (dataGridView2.SelectedRows.Count == 1)
            {
                Form_AddDatBan addDat = new Form_AddDatBan(iddatban);
                addDat.Show();
            }
            if(dataGridView2.SelectedRows.Count==0)
            {
                Form_AddDatBan addDat = new Form_AddDatBan();
                addDat.Show();
            }    
            //if (textBox4.Text=="Nhập số người" || textBox1.Text == "Nhập mã đặt bàn")
            //{
            //    return;
            //}
            //if (!int.TryParse(textBox4.Text, out int right)|| !int.TryParse(textBox1.Text, out int gg))
            //{
            //    return;
            //}
            //for(int i =0; i < DatBan_DAL.Instance.LoadTableList().Rows.Count; i++)
            //{
            //    if(int.Parse(textBox1.Text)== (int)DatBan_DAL.Instance.LoadTableList().Rows[i]["idDatBan"])
            //    {
            //        return;
            //    }
            //}
            //DataTable g = DatBan_DAL.Instance.AddRow(int.Parse(textBox1.Text),int.Parse(comboBox3.GetItemText(comboBox3.SelectedItem)), comboBox1.GetItemText(comboBox1.SelectedItem),dateTimePicker_Time.Value.TimeOfDay.ToString(),dateTimePicker_Date.Value.Date.ToString("yyyy-MM-dd"),int.Parse(textBox4.Text));
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DatBan_DAL.Instance.LoadTableList();
            loadcombox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if(dataGridView2.SelectedRows.Count==0 || dataGridView2.SelectedRows.Count > 1)
            //{
            //    return;
            //}
            //if (textBox4.Text == "Nhập số người" || textBox1.Text == "Nhập mã đặt bàn")
            //{
            //    return;
            //}
            //if (!int.TryParse(textBox4.Text, out int right) || !int.TryParse(textBox1.Text, out int gg))
            //{
            //    return;
            //}
            //DatBan_DAL.Instance.UpdateRow(int.Parse(textBox1.Text),int.Parse(comboBox3.GetItemText(comboBox3.SelectedItem)), comboBox1.GetItemText(comboBox1.SelectedItem), dateTimePicker_Time.Value.TimeOfDay.ToString(), dateTimePicker_Date.Value.Date.ToString("yyyy-MM-dd"), int.Parse(textBox4.Text));
            if (dataGridView2.SelectedRows.Count > 1)
            {
                return;
            }
            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }
            if (dataGridView2.SelectedRows.Count == 1)
            {
                Form_UpdateDatBan addDat = new Form_UpdateDatBan(iddatban);
                addDat.Show();
            }
            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DatBan_DAL.Instance.LoadTableList();
            loadcombox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count > 1)
            {
                return;
            }
            DatBan_DAL.Instance.DeleteRow(row.Cells[0].Value.ToString());
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DatBan_DAL.Instance.LoadTableList();
            loadcombox();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string gg = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (textBox_TimKiem.Text != "Tìm kiếm")
            {
                if (gg == "Số người")
                {
                    DataTable g = DatBan_DAL.Instance.SearchTable(textBox_TimKiem.Text, "SoNguoi");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = g;
                }
            }
            if (gg == "Mã đặt bàn" && comboBox4.GetItemText(comboBox4.SelectedItem) != "")
            {
                DataTable g = DatBan_DAL.Instance.SearchTable(comboBox4.GetItemText(comboBox4.SelectedItem), "idDatBan");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = g;
            }
            if (gg == "Mã khách hàng" && comboBox5.GetItemText(comboBox5.SelectedItem) != "")
            {
                DataTable g = DatBan_DAL.Instance.SearchTable(comboBox5.GetItemText(comboBox5.SelectedItem), "idKH");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = g;
            }
            if (gg == "Mã bàn" && comboBox6.GetItemText(comboBox6.SelectedItem) != "")
            {
                DataTable g = DatBan_DAL.Instance.SearchTable(comboBox6.GetItemText(comboBox6.SelectedItem), "idBan");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = g;
            }
            
            if (gg == "Thời gian đặt bàn")
            {
                DataTable g = DatBan_DAL.Instance.SearchTable(dateTimePicker1.Value.TimeOfDay.ToString(), "ThoiGian");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = g;
            }
            if (gg == "Ngày đặt bàn")
            {
                DataTable g = DatBan_DAL.Instance.SearchTable(dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"), "Ngay");
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = g;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected= true;
            row = dataGridView2.Rows[e.RowIndex];
            //DataTable DSidBan = DatBan_DAL.Instance.GetidBan();
            //DataTable DSidKH = DatBan_DAL.Instance.GetidKH();
            //if (data.Cells[2].Value.ToString()!="")
            //{
            //    dateTimePicker_Time.Value = DateTime.Parse(data.Cells[3].Value.ToString());
            //    dateTimePicker_Date.Value = DateTime.Parse(data.Cells[4].Value.ToString());
            //    for (int i = 0; i < DSidBan.Rows.Count; i++)
            //    {
            //        if ((int)DSidBan.Rows[i]["id"] == (int)data.Cells[2].Value)
            //        {
            //            comboBox3.SelectedValue = DSidBan.Rows[i]["id"];
            //        }
            //    }
            //    for (int i = 0; i < DSidKH.Rows.Count; i++)
            //    {
            //        if (DSidKH.Rows[i]["idUsernameCustom"].ToString() == data.Cells[1].Value.ToString())
            //        {
            //            comboBox1.SelectedValue = DSidKH.Rows[i]["idUsernameCustom"];
            //        }
            //    }
            //}
            ////comboBox1.SelectedItem = comboBox1.FindStringExact(data.Cells[1].Value.ToString());
            ////comboBox1.SelectedItem = 3;
            //textBox1.Text = data.Cells[0].Value.ToString();
            //textBox4.Text = data.Cells[5].Value.ToString();
            //iddatban = int.Parse(data.Cells[0].Value.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboxItem = comboBox2.GetItemText(comboBox2.SelectedItem);
            if(comboxItem=="Mã đặt bàn")
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                comboBox4.Visible = true;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                textBox_TimKiem.Visible = false;
            } 
            if(comboxItem=="Mã khách hàng")
            {
                comboBox5.Visible = true;
                comboBox4.Visible=false;
                comboBox6.Visible=false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                textBox_TimKiem.Visible=false;
            }    
            if(comboxItem=="Mã bàn")
            {
                comboBox6.Visible=true;
                comboBox4.Visible = false;
                comboBox5.Visible=false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                textBox_TimKiem.Visible = false;
            }    
            if(comboxItem=="Thời gian đặt bàn")
            {
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                textBox_TimKiem.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = false;
            }
            if (comboxItem == "Ngày đặt bàn")
            {
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                textBox_TimKiem.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = true;
            }
            if (comboxItem=="Số người")
            {
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                textBox_TimKiem.Visible = true;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource=DatBan_DAL.Instance.LoadTableList();
        }
    }
}
