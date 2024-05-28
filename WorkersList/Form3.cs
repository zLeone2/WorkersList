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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeTypeA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }


        private void LoadDataFromFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string[] headers = lines[0].Split(',');

                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                for (int i = 1; i < lines.Length; i++)
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
                    break;

                case "Type B Employee":
                    LoadDataFromFile(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt");
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
    }
}
