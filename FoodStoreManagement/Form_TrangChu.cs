using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodStoreManagement
{
    public partial class Form_TrangChu : Form
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

        public Form_TrangChu()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer_Tick);
            timer2 = new Timer();
            timer2.Interval = 10;
            timer2.Tick += new EventHandler(timer1_Tick);
        }

        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
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
                pictureBoxes_newdish[i].Image = new Bitmap(Image.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));
            }
            pictureBoxes_newdish[0].Location = new Point(0, 0);
            for (int i = 1; i < pictureBoxes_newdish.Count; i++)
            {
                pictureBoxes_newdish[i].Location = new Point(pictureBoxes_newdish[i - 1].Location.X + 180, 0);
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
                pictureBoxes_discount[i].Image = new Bitmap(Image.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));
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

            /*ImageList images = new ImageList();
            images.ImageSize = new Size(150, 120);
            for (int i = 0; i < 5; i++)
            {
                images.Images.Add(Image.FromFile(@"C:\Users\ASUS\Desktop\default_image.png"));
            }
            listView1.LargeImageList = images;
            listView3.LargeImageList = images;

            for (int itemIndex = 1; itemIndex <= 5; itemIndex++)
            {
                listView1.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
                listView3.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
            }*/
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lock_newdish = true;
            foreach (PictureBox pictureBox in pictureBoxes_newdish)
            {
                if (direction_newdish == "→")
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
            if (pictureBoxes_newdish[pictureBoxes_newdish.Count - 1].Location.X >= x_pos_newdish[x_pos_newdish.Count - 1] + 180 && direction_newdish == "←")
            {
                //MessageBox.Show(pictureBox5.Location.X.ToString());
                timer1.Stop();
                lock_newdish = false;
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

            if (lock_newdish == false)
            {
                //MessageBox.Show((newdish.Width).ToString());
                for (int i = 0; i < pictureBoxes_newdish.Count; i++)
                {
                    x_pos_newdish[i] = pictureBoxes_newdish[i].Location.X;
                    y_pos_newdish[i] = pictureBoxes_newdish[i].Location.Y;
                }
                Label ll = sender as Label;
                direction_newdish = ll.Text;
                if (pictureBoxes_newdish[pictureBoxes_newdish.Count - 1].Location.X + 210 == newdish_list.Width && direction_newdish == "→")
                {
                    pictureBoxes_newdish[0].Location = new Point(0, 0);
                    for (int i = 1; i < pictureBoxes_newdish.Count; i++)
                    {
                        pictureBoxes_newdish[i].Location = new Point(pictureBoxes_newdish[i - 1].Location.X + 180, pictureBoxes_newdish[i - 1].Location.Y);
                    }
                }
                else if (pictureBoxes_newdish[0].Location.X == 0 && direction_newdish == "←")
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
    }
}
