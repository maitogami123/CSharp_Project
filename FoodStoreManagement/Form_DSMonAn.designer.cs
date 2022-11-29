namespace FoodStoreManagement.GUI
{
    partial class Form_DSMonAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.categoryFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodStoreManagermentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodStore_ManagermentDataSet = new FoodStoreManagement.FoodStore_ManagermentDataSet();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.categoryFoodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryFoodTableAdapter = new FoodStoreManagement.FoodStore_ManagermentDataSetTableAdapters.CategoryFoodTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodStoreManagermentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodStore_ManagermentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 567);
            this.panel1.TabIndex = 24;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(587, 154);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 36);
            this.button7.TabIndex = 3;
            this.button7.Text = "Tìm kiếm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(78, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 74);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính năng";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(465, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 36);
            this.button8.TabIndex = 3;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            //New_ui
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            //this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.RowHeadersWidth = 51;
            //this.dataGridView1.Size = new System.Drawing.Size(720, 336);
            //this.dataGridView1.TabIndex = 35;
            
            // 
            // button3
            // 
            
            //this.button3.Location = new System.Drawing.Point(636, 1);
            //this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            
            //TrangChu_V
            this.button6.Location = new System.Drawing.Point(325, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 36);
            this.button6.TabIndex = 2;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Lọc:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 203);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(731, 361);
            this.dataGridView2.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(371, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.categoryFoodBindingSource;
            this.comboBox3.DisplayMember = "category";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(417, 105);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(257, 24);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.ValueMember = "category";
            // 
            // categoryFoodBindingSource
            // 
            this.categoryFoodBindingSource.DataMember = "CategoryFood";
            this.categoryFoodBindingSource.DataSource = this.foodStoreManagermentDataSetBindingSource;
            // 
            // foodStoreManagermentDataSetBindingSource
            // 
            this.foodStoreManagermentDataSetBindingSource.DataSource = this.foodStore_ManagermentDataSet;
            this.foodStoreManagermentDataSetBindingSource.Position = 0;
            // 
            // foodStore_ManagermentDataSet
            // 
            this.foodStore_ManagermentDataSet.DataSetName = "FoodStore_ManagermentDataSet";
            this.foodStore_ManagermentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Lọc theo giá từ cao đến thấp",
            "Lọc theo giá từ thấp đến cao",
            "Lọc theo tên từ A đến Z",
            "Lọc theo tên từ Z đến A"});
            this.comboBox4.Location = new System.Drawing.Point(78, 105);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(257, 24);
            this.comboBox4.TabIndex = 26;
            this.comboBox4.Text = "Chọn điều kiện lọc";
            this.comboBox4.Click += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // categoryFoodBindingSource1
            // 
            this.categoryFoodBindingSource1.DataMember = "CategoryFood";
            this.categoryFoodBindingSource1.DataSource = this.foodStoreManagermentDataSetBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(368, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Loại:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Đặt hàng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 55);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(266, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "DANH SÁCH MÓN ĂN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // categoryFoodTableAdapter
            // 
            this.categoryFoodTableAdapter.ClearBeforeFill = true;
            // 
            // Form_DSMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_DSMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DSMonAn";
            this.Load += new System.EventHandler(this.Form_DSMonAn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodStoreManagermentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodStore_ManagermentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource foodStoreManagermentDataSetBindingSource;
        private FoodStore_ManagermentDataSet foodStore_ManagermentDataSet;
        private System.Windows.Forms.BindingSource categoryFoodBindingSource;
        private FoodStore_ManagermentDataSetTableAdapters.CategoryFoodTableAdapter categoryFoodTableAdapter;
        private System.Windows.Forms.BindingSource categoryFoodBindingSource1;
        private System.Windows.Forms.Button button8;
    }
}