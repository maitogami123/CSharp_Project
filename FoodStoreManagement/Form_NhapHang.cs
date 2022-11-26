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
    public partial class Form_NhapHang : Form
    {
        public Form_NhapHang()
        {
            InitializeComponent();
        }

        private void Form_NhapHang_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
