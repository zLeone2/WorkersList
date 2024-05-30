using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeTypeA
{
    public partial class Form3 : Form
    {
        private object previousvalue;
        private string path;
        public Form3()
        {
            InitializeComponent();

        }


        private void LoadDataFromFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            string[] lines = File.ReadAllLines(filePath);
            string[] vd = lines[0].Split(',');
            string[] headersB = { "Name", "Last Name", "Employee ID", "Date of Birth", "Age", "Gender", "Address", "Phone Number", "Email", "Date of Hire", "Salary", "Hours per Week", "Bonus", "Vacation Days", "Position", "Decision Making Authority" };
            string[] headersA = { "Name", "Last Name", "Employee ID", "Date of Birth", "Age", "Gender", "Address", "Phone Number", "Email", "Date of Hire", "Salary", "Hours per Week" };
            if (lines.Length > 0)
            {
                if (vd.Length > 12)
                {
                    foreach (string header in headersB)
                    {
                        dataTable.Columns.Add(header);
                    }
                }
                else
                {
                    foreach (string header in headersA)
                    {
                        dataTable.Columns.Add(header);
                    }
                }



                for (int i = 0; i < lines.Length; i++)
                {
                    string[] cells = lines[i].Split(',');
                    dataTable.Rows.Add(cells);
                }

                dtgridEmployees.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("El archivo está vacío.");
            }
        }

        private void cboxTypeEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cboxTypeEmployee.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "Type A Employee":
                    LoadDataFromFile(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesA.txt");
                    path = @"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesA.txt";
                    break;

                case "Type B Employee":
                    LoadDataFromFile(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt");
                    path = @"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt";

                    break;


            }
        }

        private void cbExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtgridEmployees.Rows.Count == 0)
            {
                return;
            }
            string selectedOption = cbExport.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "DOCX":
                    Exporter.DOCXexport(dtgridEmployees);

                    break;

                case "XLSX":
                    Exporter.XLSXexport(dtgridEmployees);
                    break;
                case "XML":
                    Exporter.XMLexport(dtgridEmployees);
                    break;
                case "JSON":
                    Exporter.JSONexport(dtgridEmployees);
                    break;
                case "PDF":
                    Exporter.PDFexport(dtgridEmployees);
                    break;



            }
        }

        private void dtgridEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to modify the data", "Data will change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewCell cell = dtgridEmployees[e.ColumnIndex, e.RowIndex];
                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    MessageBox.Show("Value can't be null", "Valitation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cell.Value = previousvalue;
                    return;
                }
                SaveData(path);
            }
            else
            {
                ResetTable();



                return;
            }
        }

        private void SaveData(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (DataGridViewRow fila in dtgridEmployees.Rows)
                {
                    string linea = "";
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        linea += celda.Value.ToString() + ",";
                    }
                    linea = linea.TrimEnd(',');
                    writer.WriteLine(linea);
                }
            }
        }

        private void dtgridEmployees_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            previousvalue = dtgridEmployees[e.ColumnIndex, e.RowIndex].Value;

        }
        private void ResetTable()
        {
            string cboxvalue = cboxTypeEmployee.SelectedItem.ToString();
            cboxTypeEmployee.SelectedItem = "Type B Employee";
            cboxTypeEmployee.SelectedItem = "Type A Employee";
            cboxTypeEmployee.SelectedItem = cboxvalue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgridEmployees.SelectedRows.Count == 1 && dtgridEmployees.Rows.Count > 1)
            {
                DialogResult result = MessageBox.Show("This action will delete the employee permanently", "Deleting Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow filaSeleccionada in dtgridEmployees.SelectedRows)
                    {
                      
                        
                            dtgridEmployees.Rows.Remove(filaSeleccionada);
                        
                        SaveData(path);
                    }
                }
                else
                {
                    ResetTable();



                    return;
                }

            }
            else 
            {
                MessageBox.Show("Can't be empty", "Error");

            }

        }

      
    }
}
