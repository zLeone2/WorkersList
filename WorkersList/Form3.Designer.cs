namespace EmployeeTypeA
{
    partial class Form3
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
            dtgridEmployees = new DataGridView();
            cboxTypeEmployee = new ComboBox();
            cbExport = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgridEmployees).BeginInit();
            SuspendLayout();
            // 
            // dtgridEmployees
            // 
            dtgridEmployees.AllowUserToAddRows = false;
            dtgridEmployees.AllowUserToDeleteRows = false;
            dtgridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridEmployees.Location = new Point(29, 41);
            dtgridEmployees.Name = "dtgridEmployees";
            dtgridEmployees.Size = new Size(759, 409);
            dtgridEmployees.TabIndex = 0;
            // 
            // cboxTypeEmployee
            // 
            cboxTypeEmployee.AccessibleName = "";
            cboxTypeEmployee.BackColor = SystemColors.Window;
            cboxTypeEmployee.FormattingEnabled = true;
            cboxTypeEmployee.Items.AddRange(new object[] { "Type A Employee", "Type B Employee" });
            cboxTypeEmployee.Location = new Point(667, 12);
            cboxTypeEmployee.Name = "cboxTypeEmployee";
            cboxTypeEmployee.Size = new Size(121, 23);
            cboxTypeEmployee.TabIndex = 1;
            cboxTypeEmployee.Text = "Type";
            cboxTypeEmployee.SelectedIndexChanged += cboxTypeEmployee_SelectedIndexChanged;
            // 
            // cbExport
            // 
            cbExport.FormattingEnabled = true;
            cbExport.Items.AddRange(new object[] { "DOCX", "XLSX", "XML", "JSON", "PDF" });
            cbExport.Location = new Point(44, 12);
            cbExport.Name = "cbExport";
            cbExport.Size = new Size(121, 23);
            cbExport.TabIndex = 2;
            cbExport.Text = "Export";
            cbExport.SelectedIndexChanged += cbExport_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 481);
            Controls.Add(cbExport);
            Controls.Add(cboxTypeEmployee);
            Controls.Add(dtgridEmployees);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dtgridEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgridEmployees;
        private ComboBox cboxTypeEmployee;
        private ComboBox cbExport;
    }
}