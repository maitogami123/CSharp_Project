using System;
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
    public partial class Form_DSMonAn : Form
    {
        public Form_DSMonAn()
        {
            InitializeComponent();
        }

        private void Form_DatHang_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            /*ImageList images = new ImageList();
            images.ImageSize = new Size(150, 120);
            for (int i = 0; i < 5; i++)
            {
                images.Images.Add(Image.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));
            }
            //listView1.LargeImageList = images;
            listView1.LargeImageList = images;

            for (int itemIndex = 1; itemIndex <= 5; itemIndex++)
            {
                //listView1.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
                listView1.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
            }*/
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible= false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
