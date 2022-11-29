using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FoodStoreManagement.GUI
{
    public partial class Form_KhuyenMai : Form
    {
        public DiscountDetailBUS dataBUS = new DiscountDetailBUS();
        public Form_KhuyenMai()
        {
            InitializeComponent();
            Header();
            Show();
        }

        private void Form_KhuyenMai_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataBUS.getData();
        }
        public void Header()
        {
            listView2.Columns.Add("Mã số");
            listView2.Columns.Add("Phần trăm được giảm");
            listView2.Columns.Add("Hạn áp dụng");
            listView2.Columns.Add("Mã món ăn");
            listView2.View = View.Details;
        }
        public void show()
        {
            DataTable data = new DataTable();
            data = dataBUS.getData();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dataRow = data.Rows[i];
                ListViewItem item = new ListViewItem(dataRow[0].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dataRow[0].ToString());
                item.SubItems.Add(dataRow[1].ToString());
                item.SubItems.Add(dataRow[2].ToString());
                item.SubItems.Add(dataRow[3].ToString());
                listView2.Items.Add(item);
            }
            listView2.View = View.Details;
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
