using FoodStoreManagement.DAL;
using System;
using System.Data;
using System.Windows.Forms;
namespace FoodStoreManagement.GUI
{
    public partial class Form_AddFood : Form
    {
        public Form_AddFood()
        {
            InitializeComponent();
            label5.Hide();
            label6.Hide();
            label7.Hide();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool checkIdCategory(int input)
        {
            DataTable dt = new DataTable();
            dt = FoodList_DAL.Instance.ValidateAddForm__idCategory();
            foreach (DataRow dr in dt.Rows)
            {
                MessageBox.Show(input.ToString());
                if (dr["id"].ToString() == input.ToString()) return true;
                //if (dr.ToString().Equals(input)) return true;
                //foreach (DataColumn dc in dr.ItemArray)
                //{
                //    if (dr[dc].Equals(input)) return true;
                //}

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
                FoodList_DAL.Instance.AddRow(textBox1.Text, Int32.Parse(textBox3.Text), float.Parse(textBox2.Text));
                this.Close();
            }
        }

        

        
    }
}
