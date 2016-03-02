namespace DatExplorer
{
    partial class MainConsole
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_DatFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.textBoxCounts = new System.Windows.Forms.TextBox();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_DatFile
            // 
            this.textBox_DatFile.Location = new System.Drawing.Point(22, 25);
            this.textBox_DatFile.Name = "textBox_DatFile";
            this.textBox_DatFile.Size = new System.Drawing.Size(498, 20);
            this.textBox_DatFile.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(1164, 376);
            this.dataGridViewMain.TabIndex = 2;
            this.dataGridViewMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_ColumnHeaderMouseClick);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(60, 82);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 3;
            // 
            // textBoxCounts
            // 
            this.textBoxCounts.Location = new System.Drawing.Point(12, 516);
            this.textBoxCounts.Name = "textBoxCounts";
            this.textBoxCounts.Size = new System.Drawing.Size(398, 20);
            this.textBoxCounts.TabIndex = 4;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Location = new System.Drawing.Point(627, 510);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFilters.TabIndex = 5;
            this.buttonResetFilters.Text = "Reset Filters";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Apply Filters";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.textBoxCounts);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_DatFile);
            this.Name = "MainConsole";
            this.Text = "DatFileExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_DatFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TextBox textBoxCounts;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.Button button2;
    }
}

