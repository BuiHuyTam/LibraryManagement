namespace LibraryManagement
{
    partial class ViewStudentInformation
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtSName = new TextBox();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtSemester = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 148);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 1;
            label2.Text = "Student";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 52);
            label1.Name = "label1";
            label1.Size = new Size(54, 30);
            label1.TabIndex = 0;
            label1.Text = "Add";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 166);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            label3.Click += label3_Click;
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Location = new Point(331, 166);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(290, 23);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(661, 166);
            button1.Name = "button1";
            button1.Size = new Size(81, 23);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 179);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(txtDepartment);
            panel3.Controls.Add(txtEnrollment);
            panel3.Controls.Add(txtSName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtSemester);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(971, 228);
            panel3.TabIndex = 0;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(687, 81);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(271, 23);
            txtDepartment.TabIndex = 29;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(184, 77);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(271, 23);
            txtEnrollment.TabIndex = 28;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(184, 23);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(271, 23);
            txtSName.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(532, 79);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 26;
            label4.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 79);
            label8.Name = "label8";
            label8.Size = new Size(111, 21);
            label8.TabIndex = 25;
            label8.Text = "Enrollment No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 23);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 24;
            label9.Text = "Student Name";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(633, 191);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(445, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(224, 191);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(184, 132);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(271, 23);
            txtContact.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(687, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(687, 25);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(271, 23);
            txtSemester.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(532, 130);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 17;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 130);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 16;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(532, 25);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 15;
            label5.Text = "Student Semester";
            label5.Click += label5_Click;
            // 
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 601);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "ViewStudentInformation";
            Text = "ViewStudentInformation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtSemester;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtSName;
        private Label label4;
        private Label label8;
        private Label label9;
    }
}