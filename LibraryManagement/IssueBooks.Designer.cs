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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(275, 45);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
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
            panel2.Location = new Point(12, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 347);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(147, 277);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(34, 277);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(48, 144);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(159, 51);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnrollement.Location = new Point(34, 102);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(188, 22);
            txtEnrollement.TabIndex = 1;
            txtEnrollement.TextChanged += txtEnrollement_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
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
            panel3.Location = new Point(281, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 347);
            panel3.TabIndex = 2;
            // 
            // btnIssueBook
            // 
            btnIssueBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssueBook.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueBook.Location = new Point(277, 293);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(124, 28);
            btnIssueBook.TabIndex = 16;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(135, 264);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(231, 23);
            dateTimePicker.TabIndex = 15;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(135, 220);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(231, 23);
            comboBoxBooks.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(231, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(135, 131);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(231, 23);
            txtContact.TabIndex = 12;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(135, 89);
            txtSem.Name = "txtSem";
            txtSem.ReadOnly = true;
            txtSem.Size = new Size(231, 23);
            txtSem.TabIndex = 11;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(135, 46);
            txtDep.Name = "txtDep";
            txtDep.ReadOnly = true;
            txtDep.Size = new Size(231, 23);
            txtDep.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 6);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(231, 23);
            txtName.TabIndex = 9;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(82, 325);
            label11.Name = "label11";
            label11.Size = new Size(329, 16);
            label11.TabIndex = 8;
            label11.Text = "Maximum 3 Books Can be ISSUED to 1 Student";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(199, 319);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 227);
            label9.Name = "label9";
            label9.Size = new Size(86, 16);
            label9.TabIndex = 6;
            label9.Text = "Books Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 271);
            label8.Name = "label8";
            label8.Size = new Size(106, 16);
            label8.TabIndex = 5;
            label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 183);
            label7.Name = "label7";
            label7.Size = new Size(88, 16);
            label7.TabIndex = 4;
            label7.Text = "Student email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 138);
            label6.Name = "label6";
            label6.Size = new Size(100, 16);
            label6.TabIndex = 3;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 96);
            label5.Name = "label5";
            label5.Size = new Size(113, 16);
            label5.TabIndex = 2;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 53);
            label4.Name = "label4";
            label4.Size = new Size(77, 16);
            label4.TabIndex = 1;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 13);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 0;
            label3.Text = "Student name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(707, 512);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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