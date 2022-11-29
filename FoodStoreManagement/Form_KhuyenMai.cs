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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void Form_KhuyenMai_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataBUS.getData();
        }
       
        
    }
}
