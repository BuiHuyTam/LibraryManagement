﻿namespace LibraryManagement
{
    partial class ReturnBook
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
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnrollment = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBookIssueDate = new TextBox();
            txtBookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearchStudent);
            panel1.Controls.Add(txtEnterEnrollment);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 491);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(167, 380);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(38, 380);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStudent.Location = new Point(77, 256);
            btnSearchStudent.Margin = new Padding(3, 4, 3, 4);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(144, 45);
            btnSearchStudent.TabIndex = 2;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnterEnrollment
            // 
            txtEnterEnrollment.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnterEnrollment.Location = new Point(38, 200);
            txtEnterEnrollment.Margin = new Padding(3, 4, 3, 4);
            txtEnterEnrollment.Name = "txtEnterEnrollment";
            txtEnterEnrollment.Size = new Size(214, 24);
            txtEnterEnrollment.TabIndex = 1;
            txtEnterEnrollment.TextChanged += txtEnterEnrollment_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 156);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Enrollment Number";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 19);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 488);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtBookIssueDate);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(315, 516);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 188);
            panel2.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(557, 120);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(557, 63);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(86, 35);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(283, 124);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(283, 67);
            txtBookIssueDate.Margin = new Padding(3, 4, 3, 4);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.Size = new Size(228, 27);
            txtBookIssueDate.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(283, 16);
            txtBookName.Margin = new Padding(3, 4, 3, 4);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(228, 27);
            txtBookName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 128);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 2;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 71);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 1;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 20);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 592);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private TextBox txtEnterEnrollment;
        private Label label1;
        private Panel panel2;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBookIssueDate;
        private TextBox txtBookName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}