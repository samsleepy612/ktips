namespace InventoryManagement
{
    partial class AdminAddCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            addCategories_clearBtn = new Button();
            addCategories_removeBtn = new Button();
            addCategories_updateBtn = new Button();
            addCategories_addBtn = new Button();
            addCategories_category = new TextBox();
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
            panel1.Controls.Add(addCategories_clearBtn);
            panel1.Controls.Add(addCategories_removeBtn);
            panel1.Controls.Add(addCategories_updateBtn);
            panel1.Controls.Add(addCategories_addBtn);
            panel1.Controls.Add(addCategories_category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 799);
            panel1.TabIndex = 0;
            // 
            // addCategories_clearBtn
            // 
            addCategories_clearBtn.BackColor = Color.Silver;
            addCategories_clearBtn.FlatStyle = FlatStyle.Flat;
            addCategories_clearBtn.Font = new Font("Times New Roman", 14.25F);
            addCategories_clearBtn.Location = new Point(162, 230);
            addCategories_clearBtn.Name = "addCategories_clearBtn";
            addCategories_clearBtn.Size = new Size(123, 73);
            addCategories_clearBtn.TabIndex = 5;
            addCategories_clearBtn.Text = "Clear";
            addCategories_clearBtn.UseVisualStyleBackColor = false;
            addCategories_clearBtn.Click += addCategories_clearBtn_Click;
            // 
            // addCategories_removeBtn
            // 
            addCategories_removeBtn.BackColor = Color.Silver;
            addCategories_removeBtn.FlatStyle = FlatStyle.Flat;
            addCategories_removeBtn.Font = new Font("Times New Roman", 14.25F);
            addCategories_removeBtn.Location = new Point(33, 230);
            addCategories_removeBtn.Name = "addCategories_removeBtn";
            addCategories_removeBtn.Size = new Size(123, 73);
            addCategories_removeBtn.TabIndex = 4;
            addCategories_removeBtn.Text = "Remove";
            addCategories_removeBtn.UseVisualStyleBackColor = false;
            addCategories_removeBtn.Click += addCategories_removeBtn_Click;
            // 
            // addCategories_updateBtn
            // 
            addCategories_updateBtn.BackColor = Color.Silver;
            addCategories_updateBtn.FlatStyle = FlatStyle.Flat;
            addCategories_updateBtn.Font = new Font("Times New Roman", 14.25F);
            addCategories_updateBtn.Location = new Point(162, 151);
            addCategories_updateBtn.Name = "addCategories_updateBtn";
            addCategories_updateBtn.Size = new Size(123, 73);
            addCategories_updateBtn.TabIndex = 3;
            addCategories_updateBtn.Text = "Update";
            addCategories_updateBtn.UseVisualStyleBackColor = false;
            addCategories_updateBtn.Click += button2_Click;
            // 
            // addCategories_addBtn
            // 
            addCategories_addBtn.BackColor = Color.Silver;
            addCategories_addBtn.FlatStyle = FlatStyle.Flat;
            addCategories_addBtn.Font = new Font("Times New Roman", 14.25F);
            addCategories_addBtn.Location = new Point(33, 151);
            addCategories_addBtn.Name = "addCategories_addBtn";
            addCategories_addBtn.Size = new Size(123, 73);
            addCategories_addBtn.TabIndex = 2;
            addCategories_addBtn.Text = "Add";
            addCategories_addBtn.UseVisualStyleBackColor = false;
            addCategories_addBtn.Click += addCategories_addBtn_Click;
            // 
            // addCategories_category
            // 
            addCategories_category.BorderStyle = BorderStyle.FixedSingle;
            addCategories_category.Location = new Point(20, 96);
            addCategories_category.Multiline = true;
            addCategories_category.Name = "addCategories_category";
            addCategories_category.Size = new Size(282, 29);
            addCategories_category.TabIndex = 1;
            addCategories_category.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 0;
            label1.Text = "Item";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(362, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 799);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 27);
            label2.Name = "label2";
            label2.Size = new Size(234, 31);
            label2.TabIndex = 6;
            label2.Text = "Food and Beverages";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(753, 712);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AdminAddCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddCategories";
            Size = new Size(1152, 827);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox addCategories_category;
        private Button addCategories_clearBtn;
        private Button addCategories_removeBtn;
        private Button addCategories_updateBtn;
        private Button addCategories_addBtn;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
