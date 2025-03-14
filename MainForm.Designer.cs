namespace InventoryManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            CLOSE = new Button();
            panel2 = new Panel();
            cookery_btn = new Button();
            equipment_btn = new Button();
            button5 = new Button();
            BP_btn = new Button();
            FB_btn = new Button();
            dashboard_btn = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            adminDashboard1 = new AdminDashboard();
            adminAddCategories4 = new AdminAddCategories();
            adminAddCategories21 = new adminAddCategories2();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CLOSE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 26);
            label1.TabIndex = 5;
            label1.Text = "Kitchen Inventory System";
            label1.Click += label1_Click;
            // 
            // CLOSE
            // 
            CLOSE.BackColor = Color.Maroon;
            CLOSE.Cursor = Cursors.Hand;
            CLOSE.FlatAppearance.BorderColor = Color.Black;
            CLOSE.FlatStyle = FlatStyle.Flat;
            CLOSE.ForeColor = SystemColors.ButtonHighlight;
            CLOSE.Location = new Point(1355, 12);
            CLOSE.Name = "CLOSE";
            CLOSE.Size = new Size(75, 23);
            CLOSE.TabIndex = 4;
            CLOSE.Text = "CLOSE";
            CLOSE.UseVisualStyleBackColor = false;
            CLOSE.Click += CLOSE_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 113, 73);
            panel2.Controls.Add(cookery_btn);
            panel2.Controls.Add(equipment_btn);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(BP_btn);
            panel2.Controls.Add(FB_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 827);
            panel2.TabIndex = 1;
            // 
            // cookery_btn
            // 
            cookery_btn.BackColor = Color.FromArgb(63, 107, 70);
            cookery_btn.FlatAppearance.BorderSize = 0;
            cookery_btn.FlatStyle = FlatStyle.Flat;
            cookery_btn.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cookery_btn.ForeColor = Color.White;
            cookery_btn.Location = new Point(12, 452);
            cookery_btn.Name = "cookery_btn";
            cookery_btn.Size = new Size(263, 32);
            cookery_btn.TabIndex = 17;
            cookery_btn.Text = "Cookery";
            cookery_btn.UseVisualStyleBackColor = false;
            cookery_btn.Click += button7_Click;
            // 
            // equipment_btn
            // 
            equipment_btn.BackColor = Color.FromArgb(63, 107, 70);
            equipment_btn.FlatAppearance.BorderSize = 0;
            equipment_btn.FlatStyle = FlatStyle.Flat;
            equipment_btn.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equipment_btn.ForeColor = Color.White;
            equipment_btn.Location = new Point(12, 504);
            equipment_btn.Name = "equipment_btn";
            equipment_btn.Size = new Size(263, 32);
            equipment_btn.TabIndex = 16;
            equipment_btn.Text = "Equipment";
            equipment_btn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(63, 107, 70);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 783);
            button5.Name = "button5";
            button5.Size = new Size(263, 32);
            button5.TabIndex = 15;
            button5.Text = "Log out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // BP_btn
            // 
            BP_btn.BackColor = Color.FromArgb(63, 107, 70);
            BP_btn.FlatAppearance.BorderSize = 0;
            BP_btn.FlatStyle = FlatStyle.Flat;
            BP_btn.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BP_btn.ForeColor = Color.White;
            BP_btn.Location = new Point(12, 399);
            BP_btn.Name = "BP_btn";
            BP_btn.Size = new Size(263, 32);
            BP_btn.TabIndex = 14;
            BP_btn.Text = "Baking and Pastries";
            BP_btn.UseVisualStyleBackColor = false;
            BP_btn.Click += BP_btn_Click;
            // 
            // FB_btn
            // 
            FB_btn.BackColor = Color.FromArgb(63, 107, 70);
            FB_btn.FlatAppearance.BorderSize = 0;
            FB_btn.FlatStyle = FlatStyle.Flat;
            FB_btn.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FB_btn.ForeColor = Color.White;
            FB_btn.Location = new Point(12, 345);
            FB_btn.Name = "FB_btn";
            FB_btn.Size = new Size(263, 32);
            FB_btn.TabIndex = 13;
            FB_btn.Text = "Food and Beverages";
            FB_btn.UseVisualStyleBackColor = false;
            FB_btn.Click += button3_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(63, 107, 70);
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(12, 261);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(263, 32);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(119, 216);
            label4.Name = "label4";
            label4.Size = new Size(81, 26);
            label4.TabIndex = 11;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(111, 26);
            label3.TabIndex = 2;
            label3.Text = "Welcome,";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, -36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 238);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 128);
            label2.Name = "label2";
            label2.Size = new Size(0, 40);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboard1);
            panel3.Controls.Add(adminAddCategories4);
            panel3.Controls.Add(adminAddCategories21);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1152, 827);
            panel3.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1152, 827);
            adminDashboard1.TabIndex = 2;
            // 
            // adminAddCategories4
            // 
            adminAddCategories4.Location = new Point(0, -3);
            adminAddCategories4.Name = "adminAddCategories4";
            adminAddCategories4.Size = new Size(1152, 827);
            adminAddCategories4.TabIndex = 1;
            // 
            // adminAddCategories21
            // 
            adminAddCategories21.Location = new Point(0, 0);
            adminAddCategories21.Name = "adminAddCategories21";
            adminAddCategories21.Size = new Size(1152, 827);
            adminAddCategories21.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1442, 872);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CLOSE;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button dashboard_btn;
        private Button BP_btn;
        private Button FB_btn;
        private Button button5;
        private Panel panel3;
        private AdminAddCategories adminAddCategories1;
        private Button cookery_btn;
        private Button equipment_btn;
        private AdminAddCategories adminAddCategories2;
        private AdminAddCategories adminAddCategories3;
        private AdminDashboard adminDashboard1;
        private AdminAddCategories adminAddCategories4;
        private adminAddCategories2 adminAddCategories21;
    }
}