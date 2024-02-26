using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBConn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataTable GetPagedData(string connectionString, string tableName, int pageSize, int pageNumber)
        {
            DataTable pagedDataTable = new DataTable();

            // Create a SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define a SQL query with ROW_NUMBER() for paging
                string query = $@"SELECT * FROM (
                                SELECT 
                                    *, 
                                    ROW_NUMBER() OVER (ORDER BY ID) AS RowNum
                                FROM {tableName}
                             ) AS Sub
                             WHERE RowNum BETWEEN @StartRow AND @EndRow";

                // Create a SqlDataAdapter with the SQL query and SqlConnection
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Create parameters for paging
                    adapter.SelectCommand.Parameters.AddWithValue("@StartRow", (pageNumber - 1) * pageSize + 1);
                    adapter.SelectCommand.Parameters.AddWithValue("@EndRow", pageNumber * pageSize);

                    // Open the connection
                    connection.Open();

                    // Fill the DataTable with data from the database
                    adapter.Fill(pagedDataTable);

                    // Close the connection
                    connection.Close();
                }
            }

            return pagedDataTable;
        }

        private void fetchData_button_Click(object sender, EventArgs e)
        {
            String connectionString = connString_textBox.Text;

            // Call the GetPagedData method
            try
            {
                DataTable dataTable = GetPagedData(connectionString, "dbo.vish", int.Parse(pageSize_textBox.Text), int.Parse(startRow_textBox.Text));
                dataGridView1.DataSource = dataTable;

            }
            catch (Exception ex)
            {

            }
            // Display data in DataGridView
        }

        private void fetchData2_button_Click(object sender, EventArgs e)
        {
            String connectionString = connString_textBox.Text;
            SqlConnection sqlCon = new SqlConnection(connString_textBox.Text);
            sqlCon.Open();

            String q1 = "select * from dbo.vish where id =" + id_textBox.Text;

            SqlCommand cmd = new SqlCommand(q1, sqlCon);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {

            }
        }

        private void clearDataView_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

    }
}
