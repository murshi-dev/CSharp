using System.Data;
using System.Data.SqlClient;
namespace ContactsManagementCRUD
{
    public partial class Form1 : Form
    {
        private DataTable dt;//data table to hold the data from sql query
        public Form1()
        {
            InitializeComponent();
            dgv1.SelectionChanged += dgv1_SelectionChanged;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        String connectionString = "data source = LAPTOP-HSE3065I\\SQLEXPRESS; Initial Catalog = DBContactApril24; Integrated Security=True;";
        //insert
        private void button1_Click(object sender, EventArgs e)
        {

            //connect with database using SqlConnection and connection string
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //write the query
            string query = "INSERT INTO Contact(ID,Name,Number) VALUES (@ID,@Name,@Number)";

            //use this query with sql command
            SqlCommand command = new SqlCommand(query, connection);

            //retrieve the values from the text box and match with the parameters
            command.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Number", textBox3.Text);

            //execute the command
            command.ExecuteNonQuery();
            MessageBox.Show("New Contact Added to Table");
            //refresh the records display after adding records
            RefreshDataGridView();
            connection.Close();

        }
        //display
        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM Contact", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            dgv1.DataSource = dt;
        }

        //update
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE Contact SET Name=@Name, Number=@Number WHERE ID=@ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Number", textBox3.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Contact updated");
            //refresh the records display after updating records
            RefreshDataGridView();
            connection.Close();
        }

        //method to populate textbox with selected data from table
        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                //get the first selected row
                DataGridViewRow selectedRow = dgv1.SelectedRows[0];
                //fill in the textboxes
                textBox1.Text = selectedRow.Cells["ID"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Number"].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Check if there is a selected row
            if (dgv1.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int selectedID = int.Parse(dgv1.SelectedRows[0].Cells["ID"].Value.ToString());

                // Create the SQL command for deletion
                string query = "DELETE FROM Contact WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", selectedID);

                // Execute the command
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted.");

                // Refresh the DataGridView after deletion
                RefreshDataGridView();
            }

            connection.Close();

        }
    }
}
