namespace LibraryManagement
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtQuantity = new TextBox();
            txtBookPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 54);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("K2D", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 4);
            label1.Name = "label1";
            label1.Size = new Size(151, 52);
            label1.TabIndex = 0;
            label1.Text = "Add Books";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtBookPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(txtBookName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(4, 61);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 280);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(264, 239);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(174, 239);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 23);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F);
            dateTimePicker1.Location = new Point(177, 122);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 26);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10.2F);
            txtQuantity.Location = new Point(177, 198);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(271, 26);
            txtQuantity.TabIndex = 10;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Font = new Font("Segoe UI", 10.2F);
            txtBookPrice.Location = new Point(177, 159);
            txtBookPrice.Margin = new Padding(3, 2, 3, 2);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(271, 26);
            txtBookPrice.TabIndex = 9;
            txtBookPrice.TextChanged += textBox4_TextChanged;
            // 
            // txtPublication
            // 
            txtPublication.Font = new Font("Segoe UI", 10.2F);
            txtPublication.Location = new Point(177, 82);
            txtPublication.Margin = new Padding(3, 2, 3, 2);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(271, 26);
            txtPublication.TabIndex = 8;
            txtPublication.TextChanged += textBox3_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 10.2F);
            txtAuthor.Location = new Point(177, 48);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(271, 26);
            txtAuthor.TabIndex = 7;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 10.2F);
            txtBookName.Location = new Point(177, 14);
            txtBookName.Margin = new Padding(3, 2, 3, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(271, 26);
            txtBookName.TabIndex = 6;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(18, 198);
            label7.Name = "label7";
            label7.Size = new Size(97, 17);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(18, 159);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(18, 122);
            label5.Name = "label5";
            label5.Size = new Size(138, 17);
            label5.TabIndex = 3;
            label5.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(18, 82);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(18, 48);
            label3.Name = "label3";
            label3.Size = new Size(127, 17);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 344);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtQuantity;
        private TextBox txtBookPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}