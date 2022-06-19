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
        private string dbPath = @"D:\КУРСОВАЯ C#\TSP\TSP\bin\Debug\TransportDB.mdf";

        public Transport()
        {
            InitializeComponent();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            this.transportTableAdapter.Fill(this.transportDBDataSet.Transport);

            sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};");
            sqlConnection.Open();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentCeil = TransportData.SelectedCells;
            var id = TransportData[0, currentCeil[0].RowIndex].Value;
            string query = $"DELETE FROM Transport WHERE id = {id}";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
            Transport_Load(sender, e);
        }
    }
}
