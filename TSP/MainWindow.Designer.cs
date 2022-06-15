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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuelPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CitiesNumberTextBox = new System.Windows.Forms.TextBox();
            this.CitiesNumberLabel = new System.Windows.Forms.Label();
            this.TransportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TablesToolStripMenuItem,
            this.TransportToolStripMenuItem,
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
            // 
            // FuelPriceToolStripMenuItem
            // 
            this.FuelPriceToolStripMenuItem.Name = "FuelPriceToolStripMenuItem";
            this.FuelPriceToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.FuelPriceToolStripMenuItem.Text = "Стоимости топлива";
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
            // CitiesNumberTextBox
            // 
            this.CitiesNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitiesNumberTextBox.Location = new System.Drawing.Point(202, 38);
            this.CitiesNumberTextBox.Name = "CitiesNumberTextBox";
            this.CitiesNumberTextBox.Size = new System.Drawing.Size(44, 26);
            this.CitiesNumberTextBox.TabIndex = 1;
            // 
            // CitiesNumberLabel
            // 
            this.CitiesNumberLabel.AutoSize = true;
            this.CitiesNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitiesNumberLabel.Location = new System.Drawing.Point(12, 38);
            this.CitiesNumberLabel.Name = "CitiesNumberLabel";
            this.CitiesNumberLabel.Size = new System.Drawing.Size(184, 20);
            this.CitiesNumberLabel.TabIndex = 2;
            this.CitiesNumberLabel.Text = "Количество городов";
            // 
            // TransportToolStripMenuItem
            // 
            this.TransportToolStripMenuItem.Name = "TransportToolStripMenuItem";
            this.TransportToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.TransportToolStripMenuItem.Text = "Транспорт";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CitiesNumberLabel);
            this.Controls.Add(this.CitiesNumberTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Построение маршрута";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox CitiesNumberTextBox;
        private System.Windows.Forms.Label CitiesNumberLabel;
    }
}

