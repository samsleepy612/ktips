using System.Data;
using Microsoft.Data.SqlClient;


namespace InventoryManagement
{
    public partial class AdminAddCategories : UserControl
    {
        Microsoft.Data.SqlClient.SqlConnection connect = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public AdminAddCategories()
        {
            InitializeComponent();
            displayCategoriesData();
        }

        public void checkDatabaseConnection()
        {
            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                {
                    conn.Open();
                    MessageBox.Show("Connected to Database Successfully!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void displayCategoriesData()
        {
            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM dbo.category";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update Cat ID: " + getID
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string updateData = "UPDATE category SET category = @cat WHERE id = @id";

                        using (Microsoft.Data.SqlClient.SqlCommand updateD = new Microsoft.Data.SqlClient.SqlCommand(updateData, connect))
                        {
                            updateD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                            updateD.Parameters.AddWithValue("@id", getID);

                            updateD.ExecuteNonQuery();
                            clearFields();
                            displayCategoriesData();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                {
                    try
                    {
                        conn.Open();
                        string checkCat = "SELECT * FROM dbo.category WHERE category = @cat";

                        using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(checkCat, conn))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());

                            using (Microsoft.Data.SqlClient.SqlDataAdapter adapter = new Microsoft.Data.SqlClient.SqlDataAdapter(cmd))
                            {
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show("Category: " + addCategories_category.Text.Trim() + " already exists.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }


                        string insertData = "INSERT INTO dbo.category (category, date) VALUES(@cat, @date)";
                        using (Microsoft.Data.SqlClient.SqlCommand insertD = new Microsoft.Data.SqlClient.SqlCommand(insertData, conn))
                        {
                            insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                            insertD.Parameters.AddWithValue("@date", DateTime.Now);
                            insertD.ExecuteNonQuery();
                        }

                        clearFields();
                        displayCategoriesData();
                        MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect.State == ConnectionState.Open;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clearFields()
        {
            addCategories_category.Text = "";
        }
        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells.Count > 1)
                {
                    getID = Convert.ToInt32(row.Cells[0].Value);
                    addCategories_category.Text = row.Cells[1].Value?.ToString();
                }
            }
        }

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove Cat ID: " + getID
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string removeData = "DELETE FROM category WHERE id = @id";

                        using (Microsoft.Data.SqlClient.SqlCommand deleteD = new Microsoft.Data.SqlClient.SqlCommand(removeData, connect))
                        {
                            deleteD.Parameters.AddWithValue("@id", getID);

                            deleteD.ExecuteNonQuery();
                            clearFields();
                            displayCategoriesData();

                            MessageBox.Show("Removed Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}

