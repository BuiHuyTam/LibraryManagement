using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtBookPrice.Text != "" && txtQuantity.Text != "")
            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP\\SQLEXPRESS; database = library; integrated security = True"; //thong tin SQL
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName, bAuthorm bPubl, bDate, bPrice, bQuan) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','" + price + "','" + quan + "',)";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtBookPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE your Unsave DATA.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                this.Close();
            }
        }
    }
}
