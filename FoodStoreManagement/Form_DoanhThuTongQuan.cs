using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStoreManagement.GUI
{
    public partial class Form_DoanhThuTongQuan : Form
    {
        public Form_DoanhThuTongQuan()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Form_DoanhThuTongQuan_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible= false;
        }

    }
}
