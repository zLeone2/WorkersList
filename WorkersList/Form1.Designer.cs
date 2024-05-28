namespace WorkersList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            btnSeeEmployee = new Button();
            btnObservations = new Button();
            pictureBox1 = new PictureBox();
            lblheader = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(425, 337);
            button1.Name = "button1";
            button1.Size = new Size(119, 31);
            button1.TabIndex = 0;
            button1.Text = "Add Worker";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSeeEmployee
            // 
            btnSeeEmployee.Location = new Point(275, 337);
            btnSeeEmployee.Name = "btnSeeEmployee";
            btnSeeEmployee.Size = new Size(133, 29);
            btnSeeEmployee.TabIndex = 1;
            btnSeeEmployee.Text = "See employees";
            btnSeeEmployee.UseVisualStyleBackColor = true;
            btnSeeEmployee.Click += btnSeeEmployee_Click;
            // 
            // btnObservations
            // 
            btnObservations.Location = new Point(310, 374);
            btnObservations.Name = "btnObservations";
            btnObservations.Size = new Size(204, 23);
            btnObservations.TabIndex = 2;
            btnObservations.Text = "Observations";
            btnObservations.UseVisualStyleBackColor = true;
            btnObservations.Click += btnObservations_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblheader
            // 
            lblheader.AutoSize = true;
            lblheader.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblheader.Location = new Point(305, 262);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(209, 72);
            lblheader.TabIndex = 5;
            lblheader.Text = "Coffee Linked \r\nManagement";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblheader);
            Controls.Add(pictureBox1);
            Controls.Add(btnObservations);
            Controls.Add(btnSeeEmployee);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSeeEmployee;
        private Button btnObservations;
        private PictureBox pictureBox1;
        private Label lblheader;
    }
}
