namespace InventoryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_showPass = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            login = new Button();
            create_account = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            label1 = new Label();
            CLOSE = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login);
            panel1.Controls.Add(create_account);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(166, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 495);
            panel1.TabIndex = 0;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(238, 249);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(141, 24);
            login_showPass.TabIndex = 13;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.locked_padlock__1_;
            pictureBox3.Location = new Point(238, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(238, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 286);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.Silver;
            login.Cursor = Cursors.Hand;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.Location = new Point(276, 294);
            login.Name = "login";
            login.Size = new Size(283, 34);
            login.TabIndex = 5;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // create_account
            // 
            create_account.BackColor = Color.Silver;
            create_account.Cursor = Cursors.Hand;
            create_account.FlatStyle = FlatStyle.Flat;
            create_account.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            create_account.Location = new Point(276, 346);
            create_account.Name = "create_account";
            create_account.Size = new Size(283, 36);
            create_account.TabIndex = 4;
            create_account.Text = "SIGN UP";
            create_account.UseVisualStyleBackColor = false;
            create_account.Click += create_account_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(288, 216);
            login_password.Name = "login_password";
            login_password.Size = new Size(306, 23);
            login_password.TabIndex = 2;
            // 
            // login_username
            // 
            login_username.Location = new Point(288, 143);
            login_username.Name = "login_username";
            login_username.Size = new Size(306, 23);
            login_username.TabIndex = 1;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 45);
            label1.Name = "label1";
            label1.Size = new Size(236, 40);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            label1.Click += label1_Click;
            // 
            // CLOSE
            // 
            CLOSE.BackColor = Color.Maroon;
            CLOSE.Cursor = Cursors.Hand;
            CLOSE.FlatAppearance.BorderColor = Color.Black;
            CLOSE.FlatStyle = FlatStyle.Flat;
            CLOSE.ForeColor = SystemColors.ButtonHighlight;
            CLOSE.Location = new Point(890, 12);
            CLOSE.Name = "CLOSE";
            CLOSE.Size = new Size(75, 23);
            CLOSE.TabIndex = 1;
            CLOSE.Text = "CLOSE";
            CLOSE.UseVisualStyleBackColor = false;
            CLOSE.Click += CLOSE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 113, 73);
            ClientSize = new Size(977, 685);
            Controls.Add(CLOSE);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CLOSE;
        private Label label1;
        private TextBox login_username;
        private TextBox login_password;
        private Button create_account;
        private Button login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox login_showPass;
    }
}
