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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 72);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("K2D", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 6);
            label1.Name = "label1";
            label1.Size = new Size(186, 63);
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
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 373);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(302, 319);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(199, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F);
            dateTimePicker1.Location = new Point(202, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(309, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.2F);
            textBox5.Location = new Point(202, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(309, 30);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F);
            textBox4.Location = new Point(202, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 30);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F);
            textBox3.Location = new Point(202, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 30);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(202, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 30);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F);
            textBox1.Location = new Point(202, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 30);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.Location = new Point(21, 264);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F);
            label6.Location = new Point(21, 212);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.Location = new Point(21, 162);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 3;
            label5.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(21, 110);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(21, 64);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(21, 18);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 458);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}