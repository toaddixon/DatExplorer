using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DatExplorer
{
    public partial class MainConsole : Form
    {
        DataTable dt = new DataTable();
        String sortValue;

        public MainConsole()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBox_DatFile.Text = openFileDialog1.FileName;

                //need to call sub routine here to import the file and parse it into the datagrid
                loadDatFileToDataGrid(textBox_DatFile.Text);
                //try
                //{
                //    string text = File.ReadAllText(file);
                //   size = text.Length;
                //}
                //catch (IOException)
                //{
                //    Console.WriteLine("Unable to find file.");
                // }
            }
        }

        private void loadDatFileToDataGrid(String filepath)
        {
            //get the file and load it to data grid
            //use the default delimiters
            //detect the input file type (ansi or utf8?
            //later add options for setting the delimeters
            //also gather stats on how large the file is
            //as well as how many lines and columns it contains
            try
            {
                char charDelimiter = '\u0014';
                //string stringQuote = "þ";
                char charQuote = '\u00DE'; //capital C
                char charEmpty = '\u0000';

                //StreamReader file = new StreamReader(filepath, GetEncoding(filepath));
                StreamReader file = new StreamReader(filepath, Encoding.UTF8);

                string[] columnnames = file.ReadLine().Split(charDelimiter);
                
                dt.Columns.Add("Line#");
                foreach (string c in columnnames)
                {//for now hardcode it to remove first and last characters instead of trying to deal with quotes
                    string cFieldName = c.Substring(1, c.Length - 2);
                    dt.Columns.Add(cFieldName);
                }
                //add a blank line for filtering and set it to pink bg color
                DataRow dFilter = dt.NewRow();
                dFilter[0] = "0";
                for (int x = 0; x < dFilter.ItemArray.Length - 1; x++)
                    dFilter[x + 1] = "";
                dt.Rows.Add(dFilter);

                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    //add count to first column here
                    dr[0] = dt.Rows.Count;
                    string[] values = newline.Split(charDelimiter);
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i+1] = values[i].Substring(1, values[i].Length - 2);
                    }
                    dt.Rows.Add(dr);
                }
                file.Close();
                dt.DefaultView.RowFilter = string.Format("[Control number] like '%{0}%'", textBox_OptFile.Text);



                textBoxCounts.Text = String.Format("Total Records {0} --- Filtered Records {1}", dt.Rows.Count -1, dt.DefaultView.Count-1);

                label_CountDat.Text = String.Format("{0}",dt.Rows.Count - 1);
                label_CountDat.ForeColor = System.Drawing.Color.Green;

                dataGridViewMain.DataSource = dt;
                foreach (DataGridViewColumn column in dataGridViewMain.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
                //(dataGridViewFields.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{0}'", textBoxFilter.Text);
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to find file.");
            }
            

        }

        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return Encoding.UTF32;
            return Encoding.ASCII;
        }

        private void button2_Click(object sender, EventArgs e)
        {//apply filter
            string rowFilter = "";
            bool first = true;
            //do first row
            foreach (DataGridViewColumn column in dataGridViewMain.Columns)
            {
                if (!String.IsNullOrEmpty(dataGridViewMain.Rows[0].Cells[column.Name].Value.ToString()))
                {
                    if (first)
                    {
                        rowFilter = string.Format("[{0}] like '%{1}%'", column.Name, dataGridViewMain.Rows[0].Cells[column.Name].Value);
                        first = false;
                    }
                    else
                    {
                        rowFilter += string.Format(" AND [{0}] = '{1}'", column.Name, dataGridViewMain.Rows[0].Cells[column.Name].Value);
                    }
                }
            }
            
            (dataGridViewMain.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            textBoxCounts.Text = String.Format("Total Records {0} --- Filtered Records {1}", 
                (dataGridViewMain.DataSource as DataTable).Rows.Count - 1, 
                (dataGridViewMain.DataSource as DataTable).DefaultView.Count - 1);


        }

        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            (dataGridViewMain.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            textBoxCounts.Text = String.Format("Total Records {0} --- Filtered Records {1}",
                (dataGridViewMain.DataSource as DataTable).Rows.Count - 1,
                (dataGridViewMain.DataSource as DataTable).DefaultView.Count - 1);

        }

        private void grid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {//stopped here 2/15/2016
            /*
            the sort is still moving the filter row.  Need to add a post sort trigger and a tag to locate the record and move it back to the top
            also need to freeze the top row and shade the filter
    
            try
            {
                if (e.RowIndex1 == 0)
                    e.Handled = true;
                if (e.RowIndex2 == 0)
                    e.Handled = true;
                return;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }*/
        }

        private void grid_RowNumber(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dataGridViewMain.Rows[e.RowIndex].Cells[0].Value = this.dataGridViewMain.Rows.Count;
        }

//        private void dataGridViewMain_Sorted(object sender, EventArgs e)
//        {
//
//        }

        private void dataGridViewMain_ColumnHeaderMouseClick(object sender,
                                                  DataGridViewCellMouseEventArgs e)
        {
            string col = dataGridViewMain.Columns[e.ColumnIndex].Name;
            if (col != "") sortDGV(col);
        }

        private void sortDGV(string col)
        {
            dataGridViewMain.SuspendLayout();

            dt.Columns.Add("sortMe", typeof(Int32));

            dt.DefaultView.Sort = col;

            DataRow[] dr = dt.Select("[Line#]='0'");
            for (int r = 0; r < dt.Rows.Count; r++) dt.Rows[r]["sortMe"] = 1;
            dr[0]["sortMe"] = 0;

            String sortString = "sortMe asc,[" + col + "]";
            //MessageBox.Show(dt.DefaultView.Sort.ToString());

            //if (dt.DefaultView.Sort.ToString().Equals(col))
            //if (dataGridViewMain.Columns[1].HeaderCell.SortGlyphDirection.Equals(SortOrder.Ascending))
            if (String.IsNullOrEmpty(sortValue) || !sortValue.Equals(col))
            {//then this means its another click on that field so switch to asc
                //sortString.Replace("] desc", "] desc");
                dt.DefaultView.Sort = sortString + " asc";
                dataGridViewMain.Columns[col].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                sortValue = col;
            //    MessageBox.Show("Sort is asc");
            }
            //else if (dataGridViewMain.Columns[col].HeaderCell.SortGlyphDirection.Equals(SortOrder.Descending))
            else if (sortValue.Equals(col))
            {
                dt.DefaultView.Sort = sortString + " desc";
                dataGridViewMain.Columns[col].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                sortValue = col + "desc";
            //    MessageBox.Show("sort is desc");
            }
            //else if (dataGridViewMain.Columns[col].HeaderCell.SortGlyphDirection.Equals(SortOrder.None))
            else 
            {
                dt.DefaultView.Sort = "";
                dataGridViewMain.Columns[col].HeaderCell.SortGlyphDirection = SortOrder.None;
            //    MessageBox.Show("sort unset :" + sortString);
                sortValue = null;
            }
            //  dt.DefaultView.Sort.ToString().Contains("] asc"))
            //{
            //    sortString.Replace("] asc", "] desc");
            //}
            //else //default to desc
            //    sortString += " asc";

            

            dt.Columns.Remove("sortMe");
            dataGridViewMain.ResumeLayout();

            //MessageBox.Show(dataGridViewMain.SortOrder.ToString());
            //MessageBox.Show(dt.DefaultView.Sort.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
