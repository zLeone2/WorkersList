using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using OfficeOpenXml;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace EmployeeTypeA
{
    internal class Exporter
    {

        public static void DOCXexport(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files (*.docx)|*.docx";
            saveFileDialog.Title = "Save As DOCX";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (DocX doc = DocX.Create(saveFileDialog.FileName))
                {
                    Table table = doc.AddTable(dataGridView.Rows.Count + 1, dataGridView.Columns.Count);
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        table.Rows[0].Cells[i].Paragraphs[0].Append(dataGridView.Columns[i].HeaderText);
                    }

                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            table.Rows[i + 1].Cells[j].Paragraphs[0].Append(dataGridView[j, i].Value?.ToString() ?? string.Empty);
                        }
                    }

                    doc.InsertTable(table);

                    doc.Save();
                }

                MessageBox.Show("DOCX Exported");
            }
        }
        public static void XLSXexport(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Save As XLSX";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("DataGridViewData");

                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView[j, i].Value?.ToString() ?? string.Empty;
                        }
                    }

                    File.WriteAllBytes(saveFileDialog.FileName, excelPackage.GetAsByteArray());
                }

                MessageBox.Show("XLSX Exported");
            }
        }
        public static void XMLexport(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Guardar como XML";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement root = xmlDoc.CreateElement("DataGridViewData");
                xmlDoc.AppendChild(root);

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (dataGridView.AllowUserToAddRows && row.IsNewRow)
                    {
                        continue;
                    }
                    XmlElement rowElement = xmlDoc.CreateElement("Row");
                    root.AppendChild(rowElement);

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string columnName = dataGridView.Columns[cell.ColumnIndex].Name;

                        string cellValue = (cell.Value?.ToString() ?? string.Empty).Replace(" ", "_"); 

                        XmlElement cellElement = xmlDoc.CreateElement(columnName.Replace(" ", "_"));
                        cellElement.InnerText = cellValue;
                        rowElement.AppendChild(cellElement);
                    }
                }
                xmlDoc.Save(saveFileDialog.FileName);

                MessageBox.Show("XML Table Exported");
            }
        }

        public static void JSONexport(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save as JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var rowsList = new List<Dictionary<string, object>>();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (dataGridView.AllowUserToAddRows && row.IsNewRow)
                    {
                        continue;
                    }

                    var rowDict = new Dictionary<string, object>();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowDict[dataGridView.Columns[cell.ColumnIndex].HeaderText] = cell.Value ?? string.Empty;
                    }

                    rowsList.Add(rowDict);
                }

                string json = JsonConvert.SerializeObject(rowsList, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(saveFileDialog.FileName, json);

                MessageBox.Show("JSON Table Exported");
            }
        }

        public static void PDFexport(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save As PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4);
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount);
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (dataGridView.AllowUserToAddRows && row.IsNewRow)
                        {
                            continue;
                        }

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                        }
                    }
                    
                    pdfDoc.Add(pdfTable);
                    MessageBox.Show("PDF Table Exported");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" {ex.Message}", "Error");
                }
                finally
                {
                    pdfDoc.Close();
                }
            }
        }



    }
}
