namespace EmployeeTypeA
{
    partial class Form4
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
            txtboxWrite = new TextBox();
            cbEmployees = new ComboBox();
            btnImportOB = new Button();
            btnExportOB = new Button();
            SuspendLayout();
            // 
            // txtboxWrite
            // 
            txtboxWrite.Location = new Point(146, 116);
            txtboxWrite.Multiline = true;
            txtboxWrite.Name = "txtboxWrite";
            txtboxWrite.Size = new Size(488, 233);
            txtboxWrite.TabIndex = 0;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(525, 87);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.RightToLeft = RightToLeft.No;
            cbEmployees.Size = new Size(109, 23);
            cbEmployees.TabIndex = 1;
            cbEmployees.Text = "Select Employee";
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // btnImportOB
            // 
            btnImportOB.Location = new Point(146, 87);
            btnImportOB.Name = "btnImportOB";
            btnImportOB.Size = new Size(75, 23);
            btnImportOB.TabIndex = 2;
            btnImportOB.Text = "Import Text";
            btnImportOB.UseVisualStyleBackColor = true;
            btnImportOB.Click += btnImportOB_Click;
            // 
            // btnExportOB
            // 
            btnExportOB.Location = new Point(245, 87);
            btnExportOB.Name = "btnExportOB";
            btnExportOB.Size = new Size(75, 23);
            btnExportOB.TabIndex = 3;
            btnExportOB.Text = "Export Text";
            btnExportOB.UseVisualStyleBackColor = true;
            btnExportOB.Click += btnExportOB_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportOB);
            Controls.Add(btnImportOB);
            Controls.Add(cbEmployees);
            Controls.Add(txtboxWrite);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxWrite;
        private ComboBox cbEmployees;
        private Button btnImportOB;
        private Button btnExportOB;
    }
}