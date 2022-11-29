using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManagement.Form_Add
{
    public partial class Form_DeleteOldDatBan : Form
    {
        public Form_DeleteOldDatBan()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].HeaderText = "Mã đặt bàn";
            dataGridView2.Columns[0].DataPropertyName = "idDatBan";
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
            DataTable h = DatBan_DAL.Instance.LoadTableList();
            DataTable g = h.Clone();
            g.Rows.Clear();
            //DataRow[] orderRows = h.Select("");
            foreach (DataRow dr1 in h.Rows)
            {
                
                    if (DateTime.Parse(dr1.ItemArray[3].ToString()) < DateTime.Today.AddDays(-7))
                    {
                        DataRow dr3 = g.NewRow();
                        g.ImportRow(dr1);
                    }
                
            }
            //for (int i = 0; i < h.Rows.Count; i++)
            //{
            //    if (DateTime.Parse(h.Rows[i]["Ngay"].ToString()) < DateTime.Today.AddDays(-7))
            //    {
                    
            //        g.Rows.Add(h.Rows[i]);
            //    }
            //}
            if(g.Rows.Count==0)
            {
                button1.Visible= false;
            }    
            dataGridView2.DataSource= g;
        }

        private void Form_DeleteOldDatBan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteOldDatBan();
            this.Close();
        }
        private void DeleteOldDatBan()
        {
            DataTable h = DatBan_DAL.Instance.LoadTableList();
            for (int i = 0; i < h.Rows.Count; i++)
            {
                if (DateTime.Parse(h.Rows[i]["Ngay"].ToString()) < DateTime.Today.AddDays(-7))
                {
                    DatBan_DAL.Instance.DeleteRow(h.Rows[i]["idDatBan"].ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
