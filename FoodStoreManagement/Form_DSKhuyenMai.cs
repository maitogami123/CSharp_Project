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
    public partial class Form_DSKhuyenMai : Form
    {
        public Form_DSKhuyenMai()
        {
            InitializeComponent();
            dateTimePicker_Date.MinDate = DateTime.Now;
            dateTimePicker_Date.MaxDate = DateTime.Now.AddDays(7);
        }

        private void Form_DSKhuyenMai_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible= false;
        }
    }
}
