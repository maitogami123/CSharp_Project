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
    public partial class Form_DSDatBan : Form
    {
        string SearchPlaceHolder = "Tìm kiếm";
        public Form_DSDatBan()
        {
            InitializeComponent();
            dateTimePicker_Time.Format = DateTimePickerFormat.Time;
            dateTimePicker_Time.ShowUpDown= true;
            dateTimePicker_Time.Value= DateTime.Now;
            dateTimePicker_Date.MinDate= DateTime.Now;
            dateTimePicker_Date.MaxDate = DateTime.Now.AddDays(7);
        }

        private void Form_Ban_Load(object sender, EventArgs e)
        {
            textBox_TimKiem.LostFocus += textBox_TimKiem_LostFocus;
            textBox_TimKiem.GotFocus += textBox_TimKiem_Focus;
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            textBox_TimKiem.Text = "";
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible= false;
            //throw new NotImplementedException();
        }

        private void textBox_TimKiem_LostFocus(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == "")
            {
                textBox_TimKiem.ForeColor = Color.Gray;
                textBox_TimKiem.Text = SearchPlaceHolder;
            }
        }
        private void textBox_TimKiem_Focus(object sender, EventArgs e)
        {
            if (textBox_TimKiem.Text == SearchPlaceHolder)
            {
                textBox_TimKiem.ForeColor = Color.Black;
                textBox_TimKiem.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
