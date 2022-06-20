using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TSP
{
    public partial class MainWindow : Form
    {
        private int[,] _distanceMatrix = null;
        private int[] _fuelCost = null;
        private double[,] _resultingMatrix;
        private int? _speed = null;
        private int _fuelConsumption;
        private int? _numberOfCities = null;
        static private string _dbPath = @"D:\КУРСОВАЯ C#\TSP\TSP\TransportDB.mdf";
        private string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_dbPath};";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

        private void GetDistanceMatrix()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string tempReader = reader.ReadToEnd();
                        reader.Close();

                        if (tempReader == String.Empty)
                        {
                            MessageBox.Show("Файл пуст", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string[] lines = tempReader.Split('\n');

                        if ((_numberOfCities != lines.Length) && (_numberOfCities != null))
                        {
                            MessageBox.Show("Количество городов в 2 таблицах не равно", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string[] column = lines[0].Split(' ');

                        if (lines.Length != column.Length)
                        {
                            MessageBox.Show("Матрица в файле не является квадратной", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        _numberOfCities = lines.Length;

                        _distanceMatrix = new int[lines.Length, column.Length];
                        for (int i = 0; i < lines.Length; i++)
                        {
                            column = lines[i].Split(' ');
                            for (int j = 0; j < column.Length; j++)
                            {
                                try
                                {
                                    _distanceMatrix[i, j] = Convert.ToInt32(column[j]);
                                }
                                catch (FormatException)
                                {
                                    MessageBox.Show("В матрице расстояний есть некорректные данные", "Ошибка",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    _numberOfCities = null;
                                    return;
                                }
                            }
                        }
                    }

                    MessageBox.Show("Матрица расстояний успешно подключёна", "Успех", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Ошибка подключения к файлу", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFuelCost()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string tempReader = reader.ReadToEnd();
                        reader.Close();

                        if (tempReader == String.Empty)
                        {
                            MessageBox.Show("Файл пуст", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string[] values = tempReader.Split('\n', ' ');

                        if ((_numberOfCities != values.Length) && (_numberOfCities != null))
                        {
                            MessageBox.Show("Количество городов в 2 таблицах не равно", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        _numberOfCities = values.Length;
                        _fuelCost = new int[values.Length];

                        try
                        {
                            _fuelCost = tempReader.Split('\n', ' ').Select(x => Convert.ToInt32(x)).ToArray();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("В таблице цен на топливо есть некорректные данные",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _numberOfCities = null;
                            return;
                        }

                        MessageBox.Show("Таблица цен на топливо успешно подключёна", "Успех",
                            MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Ошибка подключения к файлу", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DistancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDistanceMatrix();
        }

        private void FuelPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFuelCost();
        }

        private void TransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            transport.Show();
        }

        private void GetTransportInfoButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    if (TransportIdTextBox.Text == String.Empty)
                    {
                        MessageBox.Show("Введите индекс", "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    int id = Convert.ToInt32(TransportIdTextBox.Text);
                    SqlCommand query = new SqlCommand($"SELECT * FROM Transport WHERE Id = {id}",
                        connection);

                    SqlDataReader reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        _speed = reader.GetInt32(reader.GetOrdinal("Скорость"));
                        _fuelConsumption = reader.GetInt32(reader.GetOrdinal("Расход_топлива"));
                    }

                    if (_speed == null)
                    {
                        MessageBox.Show("Такого транспорта не существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Транспорт успешно подключён", "Успех", MessageBoxButtons.OK);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Значение индекса должно быть целочисленным", "Ошибка", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void GetResultingMatrixButton_Click(object sender, EventArgs e)
        {
            if (_distanceMatrix == null)
            {
                MessageBox.Show("Подключите матрицу расстояний", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_fuelCost == null)
            {
                MessageBox.Show("Подключите таблицу стоимости топлива", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_speed == null)
            {
                MessageBox.Show("Подключите транспорт", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ResultingMatrixDataGridView.RowCount = (int)_numberOfCities;
            ResultingMatrixDataGridView.ColumnCount = (int)_numberOfCities;

            ResultingMatrixDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            _resultingMatrix = new double[(int)_numberOfCities, (int)_numberOfCities];  
            for (int j = 0; j < _numberOfCities; j++)
                for (int i = 0; i < _numberOfCities; i++)
                {
                    _resultingMatrix[i, j] = Math.Round((Convert.ToDouble(_distanceMatrix[i, j]) / Convert.ToDouble(_speed)) * _fuelConsumption * _fuelCost[j], 2); // (расстояние до города / скорость транспорта) * потребление топлива * цену топлива
                    ResultingMatrixDataGridView.Rows[i].Cells[j].Value = Math.Round(_resultingMatrix[i, j], 2);
                }
        }

        private void GetMinPathButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (_resultingMatrix == null)
                {
                    MessageBox.Show("Расчитайте итоговую матрицу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                TSPimplementation tspImplementation = new TSPimplementation();

                tspImplementation.TSP(_resultingMatrix, (int)_numberOfCities);
                MinPathCostTextBox.Text = tspImplementation.FinalResultWrapper.ToString();

                for (int i = 0; i <= _numberOfCities; i++)
                {
                    MinPathTextBox.Text += tspImplementation.FinalPathWrapper[i].ToString() + ' ';
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }
    }
}