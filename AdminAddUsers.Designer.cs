namespace InventoryManagement
{
    partial class AdminAddUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            addUsers_status = new ComboBox();
            label4 = new Label();
            addUsers_role = new ComboBox();
            addUsers_password = new TextBox();
            label3 = new Label();
            addUsers_clearBtn = new Button();
            addUsers_removeBtn = new Button();
            addUsers_updateBtn = new Button();
            addUsers_addBtn = new Button();
            addUsers_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(addUsers_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUsers_role);
            panel1.Controls.Add(addUsers_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUsers_clearBtn);
            panel1.Controls.Add(addUsers_removeBtn);
            panel1.Controls.Add(addUsers_updateBtn);
            panel1.Controls.Add(addUsers_addBtn);
            panel1.Controls.Add(addUsers_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 799);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 306);
            label5.Name = "label5";
            label5.Size = new Size(81, 31);
            label5.TabIndex = 11;
            label5.Text = "Status";
            // 
            // addUsers_status
            // 
            addUsers_status.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_status.FormattingEnabled = true;
            addUsers_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addUsers_status.Location = new Point(21, 340);
            addUsers_status.Name = "addUsers_status";
            addUsers_status.Size = new Size(281, 33);
            addUsers_status.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 227);
            label4.Name = "label4";
            label4.Size = new Size(76, 31);
            label4.TabIndex = 9;
            label4.Text = "Roles";
            // 
            // addUsers_role
            // 
            addUsers_role.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_role.FormattingEnabled = true;
            addUsers_role.Location = new Point(21, 261);
            addUsers_role.Name = "addUsers_role";
            addUsers_role.Size = new Size(281, 33);
            addUsers_role.TabIndex = 8;
            // 
            // addUsers_password
            // 
            addUsers_password.BorderStyle = BorderStyle.FixedSingle;
            addUsers_password.Location = new Point(20, 185);
            addUsers_password.Multiline = true;
            addUsers_password.Name = "addUsers_password";
            addUsers_password.Size = new Size(282, 29);
            addUsers_password.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 141);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // addUsers_clearBtn
            // 
            addUsers_clearBtn.BackColor = Color.Silver;
            addUsers_clearBtn.FlatStyle = FlatStyle.Flat;
            addUsers_clearBtn.Font = new Font("Times New Roman", 14.25F);
            addUsers_clearBtn.Location = new Point(165, 490);
            addUsers_clearBtn.Name = "addUsers_clearBtn";
            addUsers_clearBtn.Size = new Size(123, 73);
            addUsers_clearBtn.TabIndex = 5;
            addUsers_clearBtn.Text = "Clear";
            addUsers_clearBtn.UseVisualStyleBackColor = false;
            addUsers_clearBtn.Click += addUsers_clearBtn_Click;
            // 
            // addUsers_removeBtn
            // 
            addUsers_removeBtn.BackColor = Color.Silver;
            addUsers_removeBtn.FlatStyle = FlatStyle.Flat;
            addUsers_removeBtn.Font = new Font("Times New Roman", 14.25F);
            addUsers_removeBtn.Location = new Point(36, 490);
            addUsers_removeBtn.Name = "addUsers_removeBtn";
            addUsers_removeBtn.Size = new Size(123, 73);
            addUsers_removeBtn.TabIndex = 4;
            addUsers_removeBtn.Text = "Remove";
            addUsers_removeBtn.UseVisualStyleBackColor = false;
            // 
            // addUsers_updateBtn
            // 
            addUsers_updateBtn.BackColor = Color.Silver;
            addUsers_updateBtn.FlatStyle = FlatStyle.Flat;
            addUsers_updateBtn.Font = new Font("Times New Roman", 14.25F);
            addUsers_updateBtn.Location = new Point(165, 411);
            addUsers_updateBtn.Name = "addUsers_updateBtn";
            addUsers_updateBtn.Size = new Size(123, 73);
            addUsers_updateBtn.TabIndex = 3;
            addUsers_updateBtn.Text = "Update";
            addUsers_updateBtn.UseVisualStyleBackColor = false;
            // 
            // addUsers_addBtn
            // 
            addUsers_addBtn.BackColor = Color.Silver;
            addUsers_addBtn.FlatStyle = FlatStyle.Flat;
            addUsers_addBtn.Font = new Font("Times New Roman", 14.25F);
            addUsers_addBtn.Location = new Point(36, 411);
            addUsers_addBtn.Name = "addUsers_addBtn";
            addUsers_addBtn.Size = new Size(123, 73);
            addUsers_addBtn.TabIndex = 2;
            addUsers_addBtn.Text = "Add";
            addUsers_addBtn.UseVisualStyleBackColor = false;
            addUsers_addBtn.Click += addUsers_addBtn_Click;
            // 
            // addUsers_username
            // 
            addUsers_username.BorderStyle = BorderStyle.FixedSingle;
            addUsers_username.Location = new Point(20, 96);
            addUsers_username.Multiline = true;
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(282, 29);
            addUsers_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 51);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(361, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 799);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 27);
            label2.Name = "label2";
            label2.Size = new Size(178, 31);
            label2.TabIndex = 6;
            label2.Text = "All User's Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 113, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(15, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(753, 712);
            dataGridView1.TabIndex = 0;
            // 
            // AdminAddUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 827);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddUsers";
            Text = "AdminAddUsers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addUsers_clearBtn;
        private Button addUsers_removeBtn;
        private Button addUsers_updateBtn;
        private Button addUsers_addBtn;
        private TextBox addUsers_username;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox addUsers_password;
        private Label label3;
        private Label label4;
        private ComboBox addUsers_role;
        private Label label5;
        private ComboBox addUsers_status;
    }
}