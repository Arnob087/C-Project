namespace project
{
    partial class userpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userpage));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new InfoBox.Controls.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new InfoBox.Controls.Button();
            this.button4 = new InfoBox.Controls.Button();
            this.button3 = new InfoBox.Controls.Button();
            this.button2 = new InfoBox.Controls.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new InfoBox.Controls.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new InfoBox.Controls.Button();
            this.label3 = new InfoBox.Controls.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(20, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 76);
            this.panel3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 62);
            this.label2.TabIndex = 17;
            this.label2.Text = "P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "roduct Exchange System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 493);
            this.panel1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(594, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 27);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Enter the Id\r\nYou want to see or exchange";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.DisabledForeColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(8, 109);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.MinimumSize = new System.Drawing.Size(16, 16);
            this.button6.Name = "button6";
            this.button6.PersistantMode = false;
            this.button6.Pushed = false;
            this.button6.SideBorder = InfoBox.Controls.SideBorder.None;
            this.button6.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.button6.SideBorderTopColor = System.Drawing.Color.White;
            this.button6.SideBorderWidth = 1;
            this.button6.Size = new System.Drawing.Size(74, 37);
            this.button6.TabIndex = 12;
            this.button6.Text = "Load";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button6.Click += new System.EventHandler<System.EventArgs>(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 331);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepPink;
            this.button5.DisabledForeColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(708, 253);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.MinimumSize = new System.Drawing.Size(16, 16);
            this.button5.Name = "button5";
            this.button5.PersistantMode = false;
            this.button5.Pushed = false;
            this.button5.SideBorder = InfoBox.Controls.SideBorder.None;
            this.button5.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.button5.SideBorderTopColor = System.Drawing.Color.White;
            this.button5.SideBorderWidth = 1;
            this.button5.Size = new System.Drawing.Size(209, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "Exit";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button5.Click += new System.EventHandler<System.EventArgs>(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.DisabledForeColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(708, 201);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.MinimumSize = new System.Drawing.Size(16, 16);
            this.button4.Name = "button4";
            this.button4.PersistantMode = false;
            this.button4.Pushed = false;
            this.button4.SideBorder = InfoBox.Controls.SideBorder.None;
            this.button4.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.button4.SideBorderTopColor = System.Drawing.Color.White;
            this.button4.SideBorderWidth = 1;
            this.button4.Size = new System.Drawing.Size(209, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Exchange/Buy";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button4.Click += new System.EventHandler<System.EventArgs>(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.DisabledForeColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(708, 149);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.MinimumSize = new System.Drawing.Size(16, 16);
            this.button3.Name = "button3";
            this.button3.PersistantMode = false;
            this.button3.Pushed = false;
            this.button3.SideBorder = InfoBox.Controls.SideBorder.None;
            this.button3.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.button3.SideBorderTopColor = System.Drawing.Color.White;
            this.button3.SideBorderWidth = 1;
            this.button3.Size = new System.Drawing.Size(209, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "See Details";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler<System.EventArgs>(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.DisabledForeColor = System.Drawing.Color.Gray;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(500, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.MinimumSize = new System.Drawing.Size(16, 16);
            this.button2.Name = "button2";
            this.button2.PersistantMode = false;
            this.button2.Pushed = false;
            this.button2.SideBorder = InfoBox.Controls.SideBorder.None;
            this.button2.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.button2.SideBorderTopColor = System.Drawing.Color.White;
            this.button2.SideBorderWidth = 1;
            this.button2.Size = new System.Drawing.Size(79, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "search";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler<System.EventArgs>(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 40);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.DisabledForeColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MinimumSize = new System.Drawing.Size(16, 16);
            this.label4.Name = "label4";
            this.label4.SideBorder = InfoBox.Controls.SideBorder.None;
            this.label4.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.label4.SideBorderTopColor = System.Drawing.Color.White;
            this.label4.SideBorderWidth = 1;
            this.label4.Size = new System.Drawing.Size(209, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sesrch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mobile",
            "Laptop",
            "Sound Box",
            "Headphone",
            "Camera",
            "Watch",
            "Monitor"});
            this.comboBox1.Location = new System.Drawing.Point(234, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DisabledForeColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(594, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MinimumSize = new System.Drawing.Size(16, 16);
            this.button1.Name = "button1";
            this.button1.PersistantMode = false;
            this.button1.Pushed = false;
            this.button1.SideBorder = InfoBox.Controls.SideBorder.None;
            this.button1.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.button1.SideBorderTopColor = System.Drawing.Color.White;
            this.button1.SideBorderWidth = 1;
            this.button1.Size = new System.Drawing.Size(318, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Post New Product";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler<System.EventArgs>(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.DisabledForeColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MinimumSize = new System.Drawing.Size(16, 16);
            this.label3.Name = "label3";
            this.label3.SideBorder = InfoBox.Controls.SideBorder.None;
            this.label3.SideBorderBottomColor = System.Drawing.Color.Transparent;
            this.label3.SideBorderTopColor = System.Drawing.Color.White;
            this.label3.SideBorderWidth = 1;
            this.label3.Size = new System.Drawing.Size(209, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exchange With";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "userpage";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private InfoBox.Controls.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private InfoBox.Controls.Button button1;
        private InfoBox.Controls.Label label3;
        private InfoBox.Controls.Button button2;
        private InfoBox.Controls.Button button5;
        private InfoBox.Controls.Button button4;
        private InfoBox.Controls.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InfoBox.Controls.Button button6;
        private System.Windows.Forms.TextBox textBox2;
    }
}