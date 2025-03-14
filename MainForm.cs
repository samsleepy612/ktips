using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddCategories4.Visible = false;
            adminAddCategories21.Visible = false;
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Confirmation Message"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddCategories4.Visible = true;
            adminAddCategories21.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void BP_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddCategories4.Visible = false;
            adminAddCategories21.Visible = true;
        }

        private void adminDashboard1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
