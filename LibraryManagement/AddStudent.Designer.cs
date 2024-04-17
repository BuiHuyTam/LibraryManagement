namespace LibraryManagement
{
    partial class AddStudent
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 43);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 332);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(511, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(315, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(107, 297);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(315, 210);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(271, 23);
            txtContact.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(315, 254);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(315, 166);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(271, 23);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(315, 118);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(271, 23);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(315, 66);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(271, 23);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(315, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 23);
            txtName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(71, 252);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 5;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 212);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 4;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 168);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 3;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 120);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 68);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 22);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            label2.Click += label2_Click_1;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 428);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtName;
    }
}