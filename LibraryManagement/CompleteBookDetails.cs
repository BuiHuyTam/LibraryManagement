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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LOC-DEP-TRAI\\SQLEXPRESS02; database=LibraryManagement; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // Load danh sách các sách chưa được trả
            cmd.CommandText = "SELECT IRBook.id AS IRBookID, NewBook.bname AS BookName, NewBook.bid AS BookID, IRBook.std_id, IRBook.book_issue_date FROM IRBook INNER JOIN NewBook ON IRBook.book_id = NewBook.bid WHERE IRBook.book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            // Load danh sách các sách đã được trả
            cmd.CommandText = "SELECT IRBook.id AS IRBookID, NewBook.bname AS BookName, NewBook.bid AS BookID, IRBook.std_id, IRBook.book_issue_date, IRBook.book_return_date FROM IRBook INNER JOIN NewBook ON IRBook.book_id = NewBook.bid WHERE IRBook.book_return_date IS NOT NULL";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }

    }
}
