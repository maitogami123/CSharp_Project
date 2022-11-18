using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using ListView = System.Windows.Forms.ListView;

namespace FoodStoreManagement
{
    public partial class Form3 : Form
    {
        Timer timer1;
        Timer timer2;
        bool lock_newdish = false;
        bool lock_discount = false;
        List<PictureBox> pictureBoxes_newdish = new List<PictureBox>();
        List<PictureBox> pictureBoxes_discount = new List<PictureBox>();
        List<int> x_pos_newdish = new List<int>();
        List<int> y_pos_newdish = new List<int>();
        List<int> x_pos_discount = new List<int>();
        List<int> y_pos_discount = new List<int>();
        string direction_newdish = "";
        string direction_discount = "";
        [DllImport("user32.dll")]
        static public extern bool ShowScrollBar(System.IntPtr hWnd, int wBar, bool bShow);
        private const uint SB_HORZ = 0;

        private const uint SB_VERT = 0;

        private const uint ESB_DISABLE_BOTH = 0x3;

        private const uint ESB_ENABLE_BOTH = 0x0;
        public Form3()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer_Tick);
            timer2 = new Timer();
            timer2.Interval = 10;
            timer2.Tick += new EventHandler(timer1_Tick);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Control[] matches;
            for (int i = 1; i <= 100; i++)
            {
                matches = newdish_list.Controls.Find("pictureBox" + i.ToString(), true);
                if (matches.Length > 0 && matches[0] is PictureBox)
                {
                    pictureBoxes_newdish.Add((PictureBox)matches[0]);
                }
            }
            for (int i = 0; i < pictureBoxes_newdish.Count; i++)
            {
                pictureBoxes_newdish[i].Size = new Size(150, 157);
                pictureBoxes_newdish[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxes_newdish[i].Image = new Bitmap(Image.FromFile(@"E:\AllCode\CSharp_Project\FoodStoreManagement\Background\images.jpg"));
            }
            pictureBoxes_newdish[0].Location=new Point(0,0);
            for(int i=1; i < pictureBoxes_newdish.Count; i++)
            {
                pictureBoxes_newdish[i].Location=new Point(pictureBoxes_newdish[i-1].Location.X+180,0);
            }
            for (int i = 0; i < pictureBoxes_newdish.Count; i++)
            {
                int a, b;
                a = pictureBoxes_newdish[i].Location.X;
                b = pictureBoxes_newdish[i].Location.Y;
                x_pos_newdish.Add(a);
                y_pos_newdish.Add(b);
            }
            //MessageBox.Show((newdish.Height).ToString());
            Console.WriteLine(pictureBoxes_newdish.Count.ToString());
            Control[] matches1;
            for (int i = 1; i <= 100; i++)
            {
                matches1 = discount_list.Controls.Find("pictureBox" + i.ToString(), true);
                if (matches1.Length > 0 && matches1[0] is PictureBox)
                {
                    pictureBoxes_discount.Add((PictureBox)matches1[0]);
                }
            }
            for (int i = 0; i < pictureBoxes_discount.Count; i++)
            {
                pictureBoxes_discount[i].Size = new Size(150, 90);
                pictureBoxes_discount[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxes_discount[i].Image = new Bitmap(Image.FromFile(@"E:\AllCode\CSharp_Project\FoodStoreManagement\Background\images.jpg"));
            }
            pictureBoxes_discount[0].Location = new Point(0, 0);
            for (int i = 1; i < pictureBoxes_discount.Count; i++)
            {
                pictureBoxes_discount[i].Location = new Point(pictureBoxes_discount[i - 1].Location.X + 180, 0);
            }
            for (int i = 0; i < pictureBoxes_discount.Count; i++)
            {
                int a, b;
                a = pictureBoxes_discount[i].Location.X;
                b = pictureBoxes_discount[i].Location.Y;
                x_pos_discount.Add(a);
                y_pos_discount.Add(b);
            }
            //Console.WriteLine(pictureBoxes_discount.Count.ToString());
            
            ImageList images = new ImageList();
            images.ImageSize = new Size(150, 120);
            for(int i = 0; i < 5; i++)
            {
                images.Images.Add(Image.FromFile(@"E:\AllCode\CSharp_Project\FoodStoreManagement\Background\images.jpg"));
            }
            listView1.LargeImageList = images;
            listView3.LargeImageList = images;
            
            for (int itemIndex = 1; itemIndex <= 5; itemIndex++)
            {
                listView1.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
                listView3.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
            }
            //ShowScrollBar(this.listView1.Handle, (int)SB_VERT, true);
            //Gio hang
            //ListView ds_giohang = new ListView();
            //ds_giohang.Bounds = new Rectangle(new Point(44, 35), new Size(813, 305));
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
            imageListLarge.Images.Add(Bitmap.FromFile(@"E:\AllCode\CSharp_Project\FoodStoreManagement\Background\images.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"E:\AllCode\CSharp_Project\FoodStoreManagement\Background\images.jpg"));

            //Assign the ImageList objects to the ListView.
            //listView1.LargeImageList = imageListLarge;
            //listView1.SmallImageList = imageListSmall;
            ds_giohang.StateImageList = imageListLarge;

            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            lock_newdish = true;
            foreach (PictureBox pictureBox in pictureBoxes_newdish)
            {
                if(direction_newdish=="→")
                {
                        pictureBox.Location = new Point(pictureBox.Location.X - 15, pictureBox.Location.Y);
                        Console.WriteLine(pictureBox8.Location.X.ToString());
                }
                if (direction_newdish == "←")
                {
                    pictureBox.Location = new Point(pictureBox.Location.X + 15, pictureBox.Location.Y);
                    Console.WriteLine(pictureBox8.Location.X.ToString());
                }
            }
            
            if (pictureBoxes_newdish[0].Location.X <= x_pos_newdish[0] - 180 && direction_newdish == "→")
            {
                //MessageBox.Show(pictureBox5.Location.X.ToString());
                timer1.Stop();
                lock_newdish = false;
            }
            if (pictureBoxes_newdish[pictureBoxes_newdish.Count-1].Location.X >= x_pos_newdish[x_pos_newdish.Count-1] + 180 && direction_newdish == "←")
            {
                //MessageBox.Show(pictureBox5.Location.X.ToString());
                timer1.Stop();
                lock_newdish = false;
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {
            
            if (lock_newdish==false)
            {
                //MessageBox.Show((newdish.Width).ToString());
                for (int i = 0; i < pictureBoxes_newdish.Count; i++)
                {
                    x_pos_newdish[i] = pictureBoxes_newdish[i].Location.X;
                    y_pos_newdish[i] = pictureBoxes_newdish[i].Location.Y;
                }
                Label ll= sender as Label;
                direction_newdish = ll.Text;
                if (pictureBoxes_newdish[pictureBoxes_newdish.Count - 1].Location.X + 210 == newdish_list.Width && direction_newdish=="→")
                {
                    pictureBoxes_newdish[0].Location = new Point(0, 0);
                    for (int i = 1; i < pictureBoxes_newdish.Count; i++)
                    {
                        pictureBoxes_newdish[i].Location = new Point(pictureBoxes_newdish[i - 1].Location.X + 180, pictureBoxes_newdish[i - 1].Location.Y);
                    }
                }
                else if(pictureBoxes_newdish[0].Location.X == 0 && direction_newdish=="←")
                {
                }
                else
                    timer1.Start();
            }
            //MessageBox.Show(lock_newdish.ToString());
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            lock_discount = true;
            //MessageBox.Show((discount_list.Width).ToString());
            foreach (PictureBox pictureBox in pictureBoxes_discount)
            {
                if (direction_discount == "→")
                {
                    pictureBox.Location = new Point(pictureBox.Location.X - 15, pictureBox.Location.Y);
                    //Console.WriteLine(pictureBox8.Location.X.ToString());
                }
                if (direction_discount == "←")
                {
                    pictureBox.Location = new Point(pictureBox.Location.X + 15, pictureBox.Location.Y);
                    //Console.WriteLine(pictureBox8.Location.X.ToString());
                }
            }

            if (pictureBoxes_discount[0].Location.X <= x_pos_discount[0] - 180 && direction_discount == "→")
            {
                //MessageBox.Show(pictureBox5.Location.X.ToString());
                timer2.Stop();
                lock_discount = false;
            }
            if (pictureBoxes_discount[pictureBoxes_discount.Count - 1].Location.X >= x_pos_discount[x_pos_discount.Count - 1] + 180 && direction_discount == "←")
            {
                //MessageBox.Show(pictureBox5.Location.X.ToString());
                timer2.Stop();
                lock_discount = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (lock_discount == false)
            {
                //MessageBox.Show((discount_list.Width).ToString());
                for (int i = 0; i < pictureBoxes_discount.Count; i++)
                {
                    x_pos_discount[i] = pictureBoxes_discount[i].Location.X;
                    y_pos_discount[i] = pictureBoxes_discount[i].Location.Y;
                }
                Label ll = sender as Label;
                direction_discount = ll.Text;
                if (pictureBoxes_discount[pictureBoxes_discount.Count - 1].Location.X + 210 == discount_list.Width && direction_discount == "→")
                {
                    pictureBoxes_discount[0].Location = new Point(0, 0);
                    for (int i = 1; i < pictureBoxes_discount.Count; i++)
                    {
                        pictureBoxes_discount[i].Location = new Point(pictureBoxes_discount[i - 1].Location.X + 180, pictureBoxes_discount[i - 1].Location.Y);
                    }
                }
                else if (pictureBoxes_discount[0].Location.X == 0 && direction_discount == "←")
                {
                }
                else
                    //MessageBox.Show((discount_list.Width).ToString());
                    timer2.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {

                panel3.Visible = false;
            }
            else
            {
                panel10.Visible = false;
                panel8.Visible = false;
                panel3.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ggg");
            if (panel8.Visible==true)
            {
                panel8.Visible = false;
            }
            else
                panel3.Visible = false;
                panel10.Visible=false;
                panel8.Visible=true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //ListViewItem lastVisible = listView1.TopItem;
            /*for (int i = listView1.TopItem.Index + 1; i < listView1.Items.Count; i++)
            {
                if (listView1.ClientRectangle.Contains(listView1.Items[i].Bounds))
                {
                    //lastVisible = listView1.Items[i];
                    Console.WriteLine(i.ToString());
                }
                else
                {
                    break;
                }
            }*/

            
            
        }
    }
}
