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
            cbExport = new ComboBox();
            cboxTypeEmployee = new ComboBox();
            dtgridEmployees = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgridEmployees).BeginInit();
            SuspendLayout();
            // 
            // cbExport
            // 
            cbExport.FormattingEnabled = true;
            cbExport.Items.AddRange(new object[] { "DOCX", "XLSX", "XML", "JSON", "PDF" });
            cbExport.Location = new Point(575, 412);
            cbExport.Name = "cbExport";
            cbExport.Size = new Size(121, 23);
            cbExport.TabIndex = 2;
            cbExport.Text = "Export";
            cbExport.SelectedIndexChanged += cbExport_SelectedIndexChanged;
            // 
            // cboxTypeEmployee
            // 
            cboxTypeEmployee.AccessibleName = "";
            cboxTypeEmployee.BackColor = SystemColors.Window;
            cboxTypeEmployee.FormattingEnabled = true;
            cboxTypeEmployee.Items.AddRange(new object[] { "Type A Employee", "Type B Employee" });
            cboxTypeEmployee.Location = new Point(560, 12);
            cboxTypeEmployee.Name = "cboxTypeEmployee";
            cboxTypeEmployee.Size = new Size(121, 23);
            cboxTypeEmployee.TabIndex = 1;
            cboxTypeEmployee.Text = "Type A Employee";
            cboxTypeEmployee.SelectedIndexChanged += cboxTypeEmployee_SelectedIndexChanged;
            // 
            // dtgridEmployees
            // 
            dtgridEmployees.AllowUserToAddRows = false;
            dtgridEmployees.AllowUserToDeleteRows = false;
            dtgridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridEmployees.Location = new Point(93, 41);
            dtgridEmployees.Name = "dtgridEmployees";
            dtgridEmployees.Size = new Size(635, 365);
            dtgridEmployees.TabIndex = 0;
            dtgridEmployees.CellBeginEdit += dtgridEmployees_CellBeginEdit;
            dtgridEmployees.CellEndEdit += dtgridEmployees_CellEndEdit;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Selected Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(822, 481);
            Controls.Add(btnDelete);
            Controls.Add(dtgridEmployees);
            Controls.Add(cbExport);
            Controls.Add(cboxTypeEmployee);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dtgridEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbExport;
        private ComboBox cboxTypeEmployee;
        private DataGridView dtgridEmployees;
        private Button btnDelete;
    }
}