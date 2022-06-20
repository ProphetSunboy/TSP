using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSP
{
    public partial class Transport : Form
    {
        private SqlDataAdapter _sqlDataAdapter;
        private DataSet _dataSet;
        static private string _dbPath = @"D:\КУРСОВАЯ C#\TSP\TSP\TransportDB.mdf";
        private string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_dbPath};";
        private string _sqlSelectAll = "SELECT * FROM Transport";

        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            FillTable();
            TransportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();
            _sqlDataAdapter = new SqlDataAdapter(_sqlSelectAll, connection);
            _sqlDataAdapter.TableMappings.Add("Table", "Transport");
            _dataSet = new DataSet("Transport");
            _sqlDataAdapter.Fill(_dataSet);
            connection.Close();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentCeil = TransportData.SelectedCells;
            var id = TransportData[0, currentCeil[0].RowIndex].Value;
            string query = $"DELETE FROM Transport WHERE id = {id}";

            using (SqlConnection connection = new SqlConnection(_connectionString))
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
                        MessageBox.Show("Операция удаления не была завершена", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(_sqlSelectAll, connection))
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

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EditTransportTable editTransportTable = new EditTransportTable();

                var currentCeil = TransportData.SelectedCells;
                editTransportTable.NameText = TransportData[1, currentCeil[0].RowIndex].Value.ToString();
                editTransportTable.SpeedText = TransportData[2, currentCeil[0].RowIndex].Value.ToString();
                editTransportTable.FuelConsumptionText = TransportData[3, currentCeil[0].RowIndex].Value.ToString();
                editTransportTable.type = "edit";
                editTransportTable.id = TransportData[0, currentCeil[0].RowIndex].Value.ToString();

                editTransportTable.ConnectionString = _connectionString;

                editTransportTable.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EditTransportTable editTransportTable = new EditTransportTable();

                editTransportTable.ConnectionString = _connectionString;

                editTransportTable.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления транспорта");
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}