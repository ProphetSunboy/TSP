using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP
{
    public partial class Transport : Form
    {
        public SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private string dbPath = @"D:\КУРСОВАЯ C#\TSP\TSP\TransportDB.mdf";

        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentCeil = TransportData.SelectedCells;
            var id = TransportData[0, currentCeil[0].RowIndex].Value;
            string query = $"DELETE FROM Transport WHERE id = {id}";

            using (SqlConnection connection =
                new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};"))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        sqlCommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Операция удаления не была завершена");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            FillTable();
        }

        private void FillTable()
        {

            string sqlSelectAll = "SELECT * FROM Transport";

            using (SqlConnection connection =
                new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};"))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sqlSelectAll, connection))
                {
                    try
                    {
                        connection.Open();

                        // Run the query by calling ExecuteReader().
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            // Create a data table to hold the retrieved data.
                            DataTable dataTable = new DataTable();

                            // Load the data from SqlDataReader into the data table.
                            dataTable.Load(dataReader);

                            // Display the data from the data table in the data grid view.
                            this.TransportData.DataSource = dataTable;

                            // Close the SqlDataReader.
                            dataReader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось заполнить таблицу данными");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}