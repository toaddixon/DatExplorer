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
            this.textBox_OptFile = new System.Windows.Forms.TextBox();
            this.textBoxCounts = new System.Windows.Forms.TextBox();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.browse_opt = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Validation = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_CountDat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_CountImages = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.Preview.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.dataGridViewMain.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(1380, 516);
            this.dataGridViewMain.TabIndex = 2;
            this.dataGridViewMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMain_ColumnHeaderMouseClick);
            // 
            // textBox_OptFile
            // 
            this.textBox_OptFile.Location = new System.Drawing.Point(22, 51);
            this.textBox_OptFile.Name = "textBox_OptFile";
            this.textBox_OptFile.Size = new System.Drawing.Size(498, 20);
            this.textBox_OptFile.TabIndex = 3;
            // 
            // textBoxCounts
            // 
            this.textBoxCounts.Location = new System.Drawing.Point(209, 16);
            this.textBoxCounts.Name = "textBoxCounts";
            this.textBoxCounts.Size = new System.Drawing.Size(398, 20);
            this.textBoxCounts.TabIndex = 4;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Location = new System.Drawing.Point(128, 16);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFilters.TabIndex = 5;
            this.buttonResetFilters.Text = "Reset Filters";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Apply Filters";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // browse_opt
            // 
            this.browse_opt.Location = new System.Drawing.Point(536, 51);
            this.browse_opt.Name = "browse_opt";
            this.browse_opt.Size = new System.Drawing.Size(75, 23);
            this.browse_opt.TabIndex = 7;
            this.browse_opt.Text = "Browse";
            this.browse_opt.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_CountImages);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_CountDat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(627, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 90);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Image Count:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dat Records:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Native Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Text File Count:";
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.tabPage1);
            this.Preview.Controls.Add(this.tabPage2);
            this.Preview.Controls.Add(this.Validation);
            this.Preview.Controls.Add(this.tabPage3);
            this.Preview.Location = new System.Drawing.Point(12, 98);
            this.Preview.Name = "Preview";
            this.Preview.SelectedIndex = 0;
            this.Preview.Size = new System.Drawing.Size(1401, 590);
            this.Preview.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonResetFilters);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBoxCounts);
            this.tabPage1.Controls.Add(this.dataGridViewMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1393, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1393, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Field Selections";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Validation
            // 
            this.Validation.Location = new System.Drawing.Point(4, 22);
            this.Validation.Name = "Validation";
            this.Validation.Padding = new System.Windows.Forms.Padding(3);
            this.Validation.Size = new System.Drawing.Size(1393, 564);
            this.Validation.TabIndex = 2;
            this.Validation.Text = "Validation";
            this.Validation.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1393, 564);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_CountDat
            // 
            this.label_CountDat.AutoSize = true;
            this.label_CountDat.Location = new System.Drawing.Point(116, 24);
            this.label_CountDat.Name = "label_CountDat";
            this.label_CountDat.Size = new System.Drawing.Size(0, 13);
            this.label_CountDat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            // 
            // label_CountImages
            // 
            this.label_CountImages.AutoSize = true;
            this.label_CountImages.Location = new System.Drawing.Point(116, 49);
            this.label_CountImages.Name = "label_CountImages";
            this.label_CountImages.Size = new System.Drawing.Size(0, 13);
            this.label_CountImages.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // MainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 700);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browse_opt);
            this.Controls.Add(this.textBox_OptFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_DatFile);
            this.Name = "MainConsole";
            this.Text = "DatFileExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Preview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_DatFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.TextBox textBox_OptFile;
        private System.Windows.Forms.TextBox textBoxCounts;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button browse_opt;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl Preview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_CountImages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_CountDat;
        private System.Windows.Forms.TabPage Validation;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

