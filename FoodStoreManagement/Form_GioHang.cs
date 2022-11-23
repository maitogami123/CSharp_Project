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
    public partial class Form_GioHang : Form
    {
        public Form_GioHang()
        {
            InitializeComponent();
        }

        private void Form_GioHang_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            ds_giohang.View = View.Details;
            // Select the item and subitems when selection is made.
            ds_giohang.CheckBoxes = true;
            ds_giohang.FullRowSelect = true;
            // Display grid lines.
            ds_giohang.GridLines = true;
            // Sort the items in the list in ascending order.
            ds_giohang.Sorting = SortOrder.Ascending;
            ListViewItem item1 = new ListViewItem("", 0);
            //item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("", 0);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            item2.SubItems.Add("3");
            ListViewItem item3 = new ListViewItem("", 0);
            // Place a check mark next to the item.
            //item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");
            item3.SubItems.Add("3");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.

            ds_giohang.Columns.Add("Món ăn", -2, HorizontalAlignment.Center);
            ds_giohang.Columns.Add("Tên món ăn", -2, HorizontalAlignment.Center);
            ds_giohang.Columns.Add("Số lượng", -2, HorizontalAlignment.Center);
            ds_giohang.Columns.Add("Giá tiền/1 món", -2, HorizontalAlignment.Center);
            ds_giohang.Columns.Add("Giá tiền", -2, HorizontalAlignment.Center);
            //ds_giohang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ds_giohang.Columns[0].Width = 100;
            ds_giohang.Columns[1].Width = 150;
            ds_giohang.Columns[2].Width = 75;
            ds_giohang.Columns[3].Width = 120;
            ds_giohang.Columns[4].Width = 145;

            //Add the items to the ListView.
            ds_giohang.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(100, 100);

            // Initialize the ImageList objects with bitmaps.
            imageListLarge.Images.Add(Bitmap.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));

            //Assign the ImageList objects to the ListView.
            //listView1.LargeImageList = imageListLarge;
            //listView1.SmallImageList = imageListSmall;
            ds_giohang.StateImageList = imageListLarge;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible=false;
        }
    }
}
