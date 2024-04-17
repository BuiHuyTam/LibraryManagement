namespace LibraryManagement
{
    partial class IssueBooks
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
            btnRefresh = new Button();
            btnSearch = new Button();
            txtEnrollement = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btnIssueBook = new Button();
            dateTimePicker = new DateTimePicker();
            comboBoxBooks = new ComboBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSem = new TextBox();
            txtDep = new TextBox();
            txtName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 167);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(314, 60);
            label1.Name = "label1";
            label1.Size = new Size(155, 29);
            label1.TabIndex = 0;
            label1.Text = "Issue Books";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtEnrollement);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 204);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 463);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(168, 369);
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
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(39, 369);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(55, 192);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(182, 68);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollement.Location = new Point(39, 136);
            txtEnrollement.Margin = new Padding(3, 4, 3, 4);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(214, 26);
            txtEnrollement.TabIndex = 1;
            txtEnrollement.Click += txtEnrollement_TextChanged;
            txtEnrollement.TextChanged += txtEnrollement_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 105);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 0;
            label2.Text = "Enter Enrollment Number";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(comboBoxBooks);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSem);
            panel3.Controls.Add(txtDep);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(321, 204);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 463);
            panel3.TabIndex = 2;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssueBook.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueBook.Location = new Point(317, 391);
            btnIssueBook.Margin = new Padding(3, 4, 3, 4);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(142, 37);
            btnIssueBook.TabIndex = 16;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(154, 352);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(263, 27);
            dateTimePicker.TabIndex = 15;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(154, 293);
            comboBoxBooks.Margin = new Padding(3, 4, 3, 4);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(263, 28);
            comboBoxBooks.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 235);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(154, 175);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(263, 27);
            txtContact.TabIndex = 12;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(154, 119);
            txtSem.Margin = new Padding(3, 4, 3, 4);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(263, 27);
            txtSem.TabIndex = 11;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(154, 61);
            txtDep.Margin = new Padding(3, 4, 3, 4);
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(263, 27);
            txtDep.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 8);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(263, 27);
            txtName.TabIndex = 9;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(50, 432);
            label11.Name = "label11";
            label11.Size = new Size(409, 20);
            label11.TabIndex = 8;
            label11.Text = "Maximum 3 Books Can be ISSUED to 1 Student";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(227, 425);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 303);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 6;
            label9.Text = "Books Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 361);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 5;
            label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 244);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 4;
            label7.Text = "Student email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 184);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 3;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 128);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 2;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 71);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 17);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 0;
            label3.Text = "Student name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(808, 683);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtEnrollement;
        private Label label2;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Button btnIssueBook;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxBooks;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSem;
        private TextBox txtDep;
        private TextBox txtName;
        private Label label11;
        private Label label10;
    }
}