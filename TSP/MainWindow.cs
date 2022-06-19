using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TSP
{
    public partial class MainWindow : Form
    {
        private int[,] _distanceMatrix;
        private int[] _fuelCost;
        private int[,] _resultingMatrix;
        private int? numberOfCities = null;

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

                        if ((numberOfCities != lines.Length) && (numberOfCities != null))
                        {
                            MessageBox.Show("Количество городов в 2 таблицах не равно", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        numberOfCities = lines.Length;
                        string[] column = lines[0].Split(' ');

                        if (lines.Length != column.Length)
                        {
                            MessageBox.Show("Матрица в файле не является квадратной", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

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
                                    return;
                                }
                            }
                        }
                    }
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

                        string[] lines = tempReader.Split('\n', ' ');

                        if ((numberOfCities != lines.Length) && (numberOfCities != null))
                        {
                            MessageBox.Show("Количество городов в 2 таблицах не равно", "Ошибка",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        numberOfCities = lines.Length;
                        _fuelCost = new int[lines.Length];

                        try
                        {
                            _fuelCost = tempReader.Split('\n', ' ').
                                Select(x => Convert.ToInt32(x)).ToArray();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("В таблице цен на топливо есть некорректные данные",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    MessageBox.Show(String.Join(",", _fuelCost.Select(x => x.ToString()).ToArray()), "Nazvanie");
                }
                else
                    MessageBox.Show("Ошибка подключения к файлу", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetResultingMatrix()
        {
            for (int j = 0; j < numberOfCities; j++)
                for (int i = 0; i < numberOfCities; i++)
                    _resultingMatrix[i, j] = _distanceMatrix[i, j] * _fuelCost[j]; // (расстояние до города / скорость транспорта) * потребление топлива * цену топлива
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
    }
}
