using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeTypeA
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            AddEmployeesToComboBox();
        }

        void AddEmployeesToComboBox()
        {
            string[] linesA = File.ReadAllLines(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesA.txt");
            string[] linesB = File.ReadAllLines(@"C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt");
            for (int i = 0; i < linesA.Length; i++)
            {
                string element = "";
                string[] headers = linesA[i].Split(",");
                for (int j = 0; j < 2; j++)
                {
                    element += $"\n {headers[j]}";
                }
                cbEmployees.Items.Add(element);
            }
            for (int i = 0; i < linesB.Length; i++)
            {
                string element = "";
                string[] headers = linesB[i].Split(",");
                for (int j = 0; j < 2; j++)
                {
                    element += $"\n {headers[j]}";

                }
                element += $"\n {headers[14]}";
                cbEmployees.Items.Add(element);

            }

        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtboxWrite.Text = cbEmployees.SelectedItem.ToString();
            txtboxWrite.Text += Environment.NewLine + Environment.NewLine +
                "Performance:" + Environment.NewLine + Environment.NewLine +
                "Complains:" + Environment.NewLine + Environment.NewLine +
                "Posible Raise:" + Environment.NewLine + Environment.NewLine +
                "Skills and Competencies:" + Environment.NewLine + Environment.NewLine +
                "Teamwork and Collaboration:" + Environment.NewLine + Environment.NewLine +
                "Attendance and Punctuality :";
        }

        private void btnExportOB_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo a guardar
                    string filePath = saveFileDialog.FileName;

                    // Escribir el contenido del TextBox en el archivo
                    try
                    {
                        File.WriteAllText(filePath, txtboxWrite.Text);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnImportOB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                txtboxWrite.Text = File.ReadAllText(fileName);
            }
        }
    }
}
