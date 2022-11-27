using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodStoreManagement.DAL;

namespace FoodStoreManagement.GUI
{
    public partial class Form_UpdateFood : Form
    {
        public Form_UpdateFood(int id, string foodName, int idCategory, float price)
        {
            InitializeComponent();
            textBox4.Text = id.ToString();
            textBox1.Text = foodName;
            textBox3.Text = idCategory.ToString();
            textBox2.Text = price.ToString();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }
        public bool checkIdCategory(int input)
        {
            DataTable dt = new DataTable();
            dt = FoodList_DAL.Instance.ValidateAddForm__idCategory();
            foreach (DataRow dr in dt.Rows)
            {
                
                if (dr["id"].ToString() == input.ToString()) return true;
            }
            return false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                label5.Show();
            }
            else if (checkIdCategory(Int32.Parse(textBox3.Text)) == false)
            {
                label6.Show();
            }
            else if (float.Parse(textBox2.Text) < 1000) label7.Show();
            else
            {
                FoodList_DAL.Instance.UpdateRow(Int32.Parse(textBox4.Text), textBox1.Text, Int32.Parse(textBox3.Text), float.Parse(textBox2.Text));
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
