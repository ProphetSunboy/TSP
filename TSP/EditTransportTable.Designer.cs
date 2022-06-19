namespace TSP
{
    partial class EditTransportTable
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.FuelConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameOfTransportLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.FuelConsumptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(85, 78);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(218, 78);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(100, 22);
            this.SpeedTextBox.TabIndex = 1;
            // 
            // FuelConsumptionTextBox
            // 
            this.FuelConsumptionTextBox.Location = new System.Drawing.Point(363, 78);
            this.FuelConsumptionTextBox.Name = "FuelConsumptionTextBox";
            this.FuelConsumptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.FuelConsumptionTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(218, 127);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameOfTransportLabel
            // 
            this.NameOfTransportLabel.AutoSize = true;
            this.NameOfTransportLabel.Location = new System.Drawing.Point(82, 50);
            this.NameOfTransportLabel.Name = "NameOfTransportLabel";
            this.NameOfTransportLabel.Size = new System.Drawing.Size(73, 16);
            this.NameOfTransportLabel.TabIndex = 4;
            this.NameOfTransportLabel.Text = "Название";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(218, 49);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(68, 16);
            this.SpeedLabel.TabIndex = 5;
            this.SpeedLabel.Text = "Скорость";
            // 
            // FuelConsumptionLabel
            // 
            this.FuelConsumptionLabel.AutoSize = true;
            this.FuelConsumptionLabel.Location = new System.Drawing.Point(363, 48);
            this.FuelConsumptionLabel.Name = "FuelConsumptionLabel";
            this.FuelConsumptionLabel.Size = new System.Drawing.Size(111, 16);
            this.FuelConsumptionLabel.TabIndex = 6;
            this.FuelConsumptionLabel.Text = "Расход топлива";
            // 
            // EditTransportTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 188);
            this.Controls.Add(this.FuelConsumptionLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.NameOfTransportLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FuelConsumptionTextBox);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "EditTransportTable";
            this.Text = "EditTransportTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.TextBox FuelConsumptionTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NameOfTransportLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label FuelConsumptionLabel;
    }
}