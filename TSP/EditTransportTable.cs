using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TSP
{
    public partial class EditTransportTable : Form
    {
        private SqlConnection _connection;
        public string type = string.Empty;
        public string id = string.Empty;
        public string ConnectionString;

        public string NameText
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }

        public string SpeedText
        {
            get { return SpeedTextBox.Text; }
            set { SpeedTextBox.Text = value; }
        }

        public string FuelConsumptionText
        {
            get { return FuelConsumptionTextBox.Text; }
            set { FuelConsumptionTextBox.Text = value; }
        }

        public EditTransportTable()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();

                if (type == "edit")
                {
                    string name = NameTextBox.Text;
                    int speed = Convert.ToInt32(SpeedTextBox.Text);
                    int fuelConsumption = Convert.ToInt32(FuelConsumptionTextBox.Text);

                    string query = $"UPDATE Transport SET Название='{name}', Скорость={speed}, " +
                        $"Расход_топлива={fuelConsumption} WHERE Id = {id}";

                    SqlCommand cmd = new SqlCommand(query, _connection);
                    cmd.ExecuteNonQuery();

                    this.Close();
                    type = "";
                }
                else
                {
                    string name = NameTextBox.Text;
                    int speed = Convert.ToInt32(SpeedTextBox.Text);
                    int fuelConsumption = Convert.ToInt32(FuelConsumptionTextBox.Text);

                    string query = "Insert Into Transport " +
                            $"(Название, Скорость, Расход_топлива) Values({name}, {speed}, {fuelConsumption})";

                    SqlCommand cmd = new SqlCommand(query, _connection);
                    cmd.ExecuteNonQuery();

                    NameTextBox.Text = string.Empty;
                    SpeedTextBox.Text = string.Empty;
                    FuelConsumptionTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
