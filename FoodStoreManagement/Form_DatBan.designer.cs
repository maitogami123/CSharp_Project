namespace FoodStoreManagement.GUI
{
    partial class Form_DatBan
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
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 20);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đặt bàn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.dateTimePicker_Date);
            this.panel1.Controls.Add(this.dateTimePicker_Time);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(36, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 257);
            this.panel1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(263, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Nhập số người";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Nhập tên khách hàng";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_Date.Location = new System.Drawing.Point(134, 30);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker_Date.TabIndex = 3;
            this.dateTimePicker_Date.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // dateTimePicker_Time
            // 
            this.dateTimePicker_Time.CustomFormat = "HH:mm";
            this.dateTimePicker_Time.Location = new System.Drawing.Point(0, 30);
            this.dateTimePicker_Time.Name = "dateTimePicker_Time";
            this.dateTimePicker_Time.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker_Time.TabIndex = 2;
            this.dateTimePicker_Time.Value = new System.DateTime(2022, 11, 21, 3, 0, 0, 0);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Đăt bàn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 182);
            this.dataGridView1.TabIndex = 23;
            // 
            // Form_DatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DatBan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DatBan";
            this.Load += new System.EventHandler(this.Form_DatBan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}