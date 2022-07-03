namespace TSP
{
    partial class Transport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transport));
            this.TransportData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скоростьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Расход_топлива = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportDBDataSet1 = new TSP.TransportDBDataSet1();
            this.DBMenu = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportTableAdapter1 = new TSP.TransportDBDataSet1TableAdapters.TransportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDBDataSet1)).BeginInit();
            this.DBMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransportData
            // 
            this.TransportData.AutoGenerateColumns = false;
            this.TransportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.скоростьDataGridViewTextBoxColumn,
            this.Расход_топлива});
            this.TransportData.DataSource = this.transportBindingSource1;
            this.TransportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransportData.Location = new System.Drawing.Point(0, 28);
            this.TransportData.Name = "TransportData";
            this.TransportData.RowHeadersWidth = 51;
            this.TransportData.RowTemplate.Height = 24;
            this.TransportData.Size = new System.Drawing.Size(793, 244);
            this.TransportData.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // скоростьDataGridViewTextBoxColumn
            // 
            this.скоростьDataGridViewTextBoxColumn.DataPropertyName = "Скорость";
            this.скоростьDataGridViewTextBoxColumn.HeaderText = "Скорость";
            this.скоростьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.скоростьDataGridViewTextBoxColumn.Name = "скоростьDataGridViewTextBoxColumn";
            this.скоростьDataGridViewTextBoxColumn.Width = 125;
            // 
            // Расход_топлива
            // 
            this.Расход_топлива.DataPropertyName = "Расход_топлива";
            this.Расход_топлива.HeaderText = "Расход топлива";
            this.Расход_топлива.MinimumWidth = 6;
            this.Расход_топлива.Name = "Расход_топлива";
            this.Расход_топлива.Width = 125;
            // 
            // transportBindingSource1
            // 
            this.transportBindingSource1.DataMember = "Transport";
            this.transportBindingSource1.DataSource = this.transportDBDataSet1;
            // 
            // transportDBDataSet1
            // 
            this.transportDBDataSet1.DataSetName = "TransportDBDataSet1";
            this.transportDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DBMenu
            // 
            this.DBMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DBMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.DBMenu.Location = new System.Drawing.Point(0, 0);
            this.DBMenu.Name = "DBMenu";
            this.DBMenu.Size = new System.Drawing.Size(793, 28);
            this.DBMenu.TabIndex = 1;
            this.DBMenu.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.RefreshToolStripMenuItem.Text = "Обновить";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // transportTableAdapter1
            // 
            this.transportTableAdapter1.ClearBeforeFill = true;
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 272);
            this.Controls.Add(this.TransportData);
            this.Controls.Add(this.DBMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.DBMenu;
            this.MaximizeBox = false;
            this.Name = "Transport";
            this.Text = "Транспорт";
            this.Load += new System.EventHandler(this.Transport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDBDataSet1)).EndInit();
            this.DBMenu.ResumeLayout(false);
            this.DBMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransportData;
        private System.Windows.Forms.MenuStrip DBMenu;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private TransportDBDataSet1 transportDBDataSet1;
        private System.Windows.Forms.BindingSource transportBindingSource1;
        private TransportDBDataSet1TableAdapters.TransportTableAdapter transportTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скоростьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Расход_топлива;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
    }
}