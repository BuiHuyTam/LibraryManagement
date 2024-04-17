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
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 197);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 109);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 1;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(509, 69);
            label1.Name = "label1";
            label1.Size = new Size(70, 37);
            label1.TabIndex = 0;
            label1.Text = "Add";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 221);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Location = new Point(378, 221);
            txtSearchEnrollment.Margin = new Padding(3, 4, 3, 4);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(331, 27);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(755, 221);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(93, 31);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
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
            panel3.Location = new Point(0, 500);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 304);
            panel3.TabIndex = 0;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(785, 108);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(309, 27);
            txtDepartment.TabIndex = 29;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(210, 103);
            txtEnrollment.Margin = new Padding(3, 4, 3, 4);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(309, 27);
            txtEnrollment.TabIndex = 28;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(210, 31);
            txtSName.Margin = new Padding(3, 4, 3, 4);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(309, 27);
            txtSName.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(608, 105);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 26;
            label4.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 105);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 25;
            label8.Text = "Enrollment No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(47, 31);
            label9.Name = "label9";
            label9.Size = new Size(137, 28);
            label9.TabIndex = 24;
            label9.Text = "Student Name";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(723, 255);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(509, 255);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(256, 255);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(210, 176);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(309, 27);
            txtContact.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(785, 171);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(785, 33);
            txtSemester.Margin = new Padding(3, 4, 3, 4);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(309, 27);
            txtSemester.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(608, 173);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 17;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 173);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 16;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(608, 33);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 15;
            label5.Text = "Student Semester";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 253);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1110, 239);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ViewStudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 801);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewStudentInformation";
            Text = "ViewStudentInformation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}