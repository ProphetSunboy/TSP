namespace TSP
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuelPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportIdTextBox = new System.Windows.Forms.TextBox();
            this.TransportIdLabel = new System.Windows.Forms.Label();
            this.GetTransportInfoButton = new System.Windows.Forms.Button();
            this.ResultingMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultingMatrixLabel = new System.Windows.Forms.Label();
            this.GetResultingMatrixButton = new System.Windows.Forms.Button();
            this.GetMinPathButton = new System.Windows.Forms.Button();
            this.MinPathLabel = new System.Windows.Forms.Label();
            this.MinPathCostLabel = new System.Windows.Forms.Label();
            this.MinPathTextBox = new System.Windows.Forms.TextBox();
            this.MinPathCostTextBox = new System.Windows.Forms.TextBox();
            this.PathVisualisingDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingMatrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathVisualisingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TablesToolStripMenuItem,
            this.TransportToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.AboutApplicationToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TablesToolStripMenuItem
            // 
            this.TablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DistancesToolStripMenuItem,
            this.FuelPriceToolStripMenuItem});
            this.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem";
            this.TablesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.TablesToolStripMenuItem.Text = "Таблицы";
            // 
            // DistancesToolStripMenuItem
            // 
            this.DistancesToolStripMenuItem.Name = "DistancesToolStripMenuItem";
            this.DistancesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.DistancesToolStripMenuItem.Text = "Расстояний";
            this.DistancesToolStripMenuItem.Click += new System.EventHandler(this.DistancesToolStripMenuItem_Click);
            // 
            // FuelPriceToolStripMenuItem
            // 
            this.FuelPriceToolStripMenuItem.Name = "FuelPriceToolStripMenuItem";
            this.FuelPriceToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.FuelPriceToolStripMenuItem.Text = "Стоимости топлива";
            this.FuelPriceToolStripMenuItem.Click += new System.EventHandler(this.FuelPriceToolStripMenuItem_Click);
            // 
            // TransportToolStripMenuItem
            // 
            this.TransportToolStripMenuItem.Name = "TransportToolStripMenuItem";
            this.TransportToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.TransportToolStripMenuItem.Text = "Транспорт";
            this.TransportToolStripMenuItem.Click += new System.EventHandler(this.TransportToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // AboutApplicationToolStripMenuItem
            // 
            this.AboutApplicationToolStripMenuItem.Name = "AboutApplicationToolStripMenuItem";
            this.AboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.AboutApplicationToolStripMenuItem.Text = "О программе";
            this.AboutApplicationToolStripMenuItem.Click += new System.EventHandler(this.AboutApplicationToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TransportIdTextBox
            // 
            this.TransportIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportIdTextBox.Location = new System.Drawing.Point(17, 75);
            this.TransportIdTextBox.Name = "TransportIdTextBox";
            this.TransportIdTextBox.Size = new System.Drawing.Size(59, 27);
            this.TransportIdTextBox.TabIndex = 3;
            // 
            // TransportIdLabel
            // 
            this.TransportIdLabel.AutoSize = true;
            this.TransportIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportIdLabel.Location = new System.Drawing.Point(13, 43);
            this.TransportIdLabel.Name = "TransportIdLabel";
            this.TransportIdLabel.Size = new System.Drawing.Size(205, 20);
            this.TransportIdLabel.TabIndex = 4;
            this.TransportIdLabel.Text = "Введите id транспорта";
            // 
            // GetTransportInfoButton
            // 
            this.GetTransportInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetTransportInfoButton.Location = new System.Drawing.Point(17, 117);
            this.GetTransportInfoButton.Name = "GetTransportInfoButton";
            this.GetTransportInfoButton.Size = new System.Drawing.Size(108, 46);
            this.GetTransportInfoButton.TabIndex = 5;
            this.GetTransportInfoButton.Text = "Подключить транспорт";
            this.GetTransportInfoButton.UseVisualStyleBackColor = true;
            this.GetTransportInfoButton.Click += new System.EventHandler(this.GetTransportInfoButton_Click);
            // 
            // ResultingMatrixDataGridView
            // 
            this.ResultingMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultingMatrixDataGridView.Location = new System.Drawing.Point(328, 75);
            this.ResultingMatrixDataGridView.Name = "ResultingMatrixDataGridView";
            this.ResultingMatrixDataGridView.RowHeadersWidth = 51;
            this.ResultingMatrixDataGridView.RowTemplate.Height = 24;
            this.ResultingMatrixDataGridView.Size = new System.Drawing.Size(460, 157);
            this.ResultingMatrixDataGridView.TabIndex = 6;
            // 
            // ResultingMatrixLabel
            // 
            this.ResultingMatrixLabel.AutoSize = true;
            this.ResultingMatrixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultingMatrixLabel.Location = new System.Drawing.Point(324, 43);
            this.ResultingMatrixLabel.Name = "ResultingMatrixLabel";
            this.ResultingMatrixLabel.Size = new System.Drawing.Size(170, 20);
            this.ResultingMatrixLabel.TabIndex = 7;
            this.ResultingMatrixLabel.Text = "Итоговая матрица:";
            // 
            // GetResultingMatrixButton
            // 
            this.GetResultingMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetResultingMatrixButton.Location = new System.Drawing.Point(328, 239);
            this.GetResultingMatrixButton.Name = "GetResultingMatrixButton";
            this.GetResultingMatrixButton.Size = new System.Drawing.Size(460, 32);
            this.GetResultingMatrixButton.TabIndex = 8;
            this.GetResultingMatrixButton.Text = "Рассчитать итоговую матрицу";
            this.GetResultingMatrixButton.UseVisualStyleBackColor = true;
            this.GetResultingMatrixButton.Click += new System.EventHandler(this.GetResultingMatrixButton_Click);
            // 
            // GetMinPathButton
            // 
            this.GetMinPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.GetMinPathButton.Location = new System.Drawing.Point(25, 356);
            this.GetMinPathButton.Name = "GetMinPathButton";
            this.GetMinPathButton.Size = new System.Drawing.Size(348, 30);
            this.GetMinPathButton.TabIndex = 9;
            this.GetMinPathButton.Text = "Найти минимальный путь";
            this.GetMinPathButton.UseVisualStyleBackColor = true;
            this.GetMinPathButton.Click += new System.EventHandler(this.GetMinPathButton_Click);
            // 
            // MinPathLabel
            // 
            this.MinPathLabel.AutoSize = true;
            this.MinPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.MinPathLabel.Location = new System.Drawing.Point(21, 297);
            this.MinPathLabel.Name = "MinPathLabel";
            this.MinPathLabel.Size = new System.Drawing.Size(175, 20);
            this.MinPathLabel.TabIndex = 10;
            this.MinPathLabel.Text = "Минимальный путь:";
            // 
            // MinPathCostLabel
            // 
            this.MinPathCostLabel.AutoSize = true;
            this.MinPathCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.MinPathCostLabel.Location = new System.Drawing.Point(22, 328);
            this.MinPathCostLabel.Name = "MinPathCostLabel";
            this.MinPathCostLabel.Size = new System.Drawing.Size(277, 20);
            this.MinPathCostLabel.TabIndex = 12;
            this.MinPathCostLabel.Text = "Стоимость минимального пути:";
            // 
            // MinPathTextBox
            // 
            this.MinPathTextBox.Location = new System.Drawing.Point(202, 297);
            this.MinPathTextBox.Name = "MinPathTextBox";
            this.MinPathTextBox.ReadOnly = true;
            this.MinPathTextBox.Size = new System.Drawing.Size(171, 22);
            this.MinPathTextBox.TabIndex = 13;
            // 
            // MinPathCostTextBox
            // 
            this.MinPathCostTextBox.Location = new System.Drawing.Point(305, 326);
            this.MinPathCostTextBox.Name = "MinPathCostTextBox";
            this.MinPathCostTextBox.ReadOnly = true;
            this.MinPathCostTextBox.Size = new System.Drawing.Size(68, 22);
            this.MinPathCostTextBox.TabIndex = 14;
            // 
            // PathVisualisingDataGridView
            // 
            this.PathVisualisingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PathVisualisingDataGridView.Location = new System.Drawing.Point(394, 297);
            this.PathVisualisingDataGridView.Name = "PathVisualisingDataGridView";
            this.PathVisualisingDataGridView.RowHeadersWidth = 51;
            this.PathVisualisingDataGridView.RowTemplate.Height = 24;
            this.PathVisualisingDataGridView.Size = new System.Drawing.Size(394, 89);
            this.PathVisualisingDataGridView.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PathVisualisingDataGridView);
            this.Controls.Add(this.MinPathCostTextBox);
            this.Controls.Add(this.MinPathTextBox);
            this.Controls.Add(this.MinPathCostLabel);
            this.Controls.Add(this.MinPathLabel);
            this.Controls.Add(this.GetMinPathButton);
            this.Controls.Add(this.GetResultingMatrixButton);
            this.Controls.Add(this.ResultingMatrixLabel);
            this.Controls.Add(this.ResultingMatrixDataGridView);
            this.Controls.Add(this.GetTransportInfoButton);
            this.Controls.Add(this.TransportIdLabel);
            this.Controls.Add(this.TransportIdTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Построение маршрута";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingMatrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathVisualisingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DistancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FuelPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransportToolStripMenuItem;
        private System.Windows.Forms.TextBox TransportIdTextBox;
        private System.Windows.Forms.Label TransportIdLabel;
        private System.Windows.Forms.Button GetTransportInfoButton;
        private System.Windows.Forms.DataGridView ResultingMatrixDataGridView;
        private System.Windows.Forms.Label ResultingMatrixLabel;
        private System.Windows.Forms.Button GetResultingMatrixButton;
        private System.Windows.Forms.Button GetMinPathButton;
        private System.Windows.Forms.Label MinPathLabel;
        private System.Windows.Forms.Label MinPathCostLabel;
        private System.Windows.Forms.TextBox MinPathTextBox;
        private System.Windows.Forms.TextBox MinPathCostTextBox;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.DataGridView PathVisualisingDataGridView;
    }
}

