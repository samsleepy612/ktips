namespace InventoryManagement
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            register_showPass = new CheckBox();
            back = new Button();
            pictureBox4 = new PictureBox();
            register_cPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            sign_up = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label1 = new Label();
            CLOSE = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(register_showPass);
            panel1.Controls.Add(back);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(sign_up);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(166, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 495);
            panel1.TabIndex = 2;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(238, 281);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(141, 24);
            register_showPass.TabIndex = 14;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // back
            // 
            back.BackColor = Color.Silver;
            back.Cursor = Cursors.Hand;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(444, 336);
            back.Name = "back";
            back.Size = new Size(140, 34);
            back.TabIndex = 11;
            back.Text = "BACK";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.locked_padlock__1_;
            pictureBox4.Location = new Point(238, 242);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 33);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(288, 248);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.Size = new Size(306, 23);
            register_cPassword.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.locked_padlock__1_;
            pictureBox3.Location = new Point(238, 180);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(238, 120);
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
            // sign_up
            // 
            sign_up.BackColor = Color.Silver;
            sign_up.Cursor = Cursors.Hand;
            sign_up.FlatStyle = FlatStyle.Flat;
            sign_up.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_up.Location = new Point(256, 336);
            sign_up.Name = "sign_up";
            sign_up.Size = new Size(140, 34);
            sign_up.TabIndex = 5;
            sign_up.Text = "SIGN UP";
            sign_up.UseVisualStyleBackColor = false;
            sign_up.Click += login_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(288, 185);
            register_password.Name = "register_password";
            register_password.Size = new Size(306, 23);
            register_password.TabIndex = 2;
            register_password.TextChanged += register_password_TextChanged;
            // 
            // register_username
            // 
            register_username.Location = new Point(288, 125);
            register_username.Name = "register_username";
            register_username.Size = new Size(306, 23);
            register_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 45);
            label1.Name = "label1";
            label1.Size = new Size(251, 40);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
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
            CLOSE.TabIndex = 3;
            CLOSE.Text = "CLOSE";
            CLOSE.UseVisualStyleBackColor = false;
            CLOSE.Click += CLOSE_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 113, 73);
            ClientSize = new Size(977, 685);
            Controls.Add(panel1);
            Controls.Add(CLOSE);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button sign_up;
        private TextBox register_password;
        private TextBox register_username;
        private Label label1;
        private Button CLOSE;
        private TextBox register_cPassword;
        private PictureBox pictureBox4;
        private Button back;
        private CheckBox register_showPass;
    }
}