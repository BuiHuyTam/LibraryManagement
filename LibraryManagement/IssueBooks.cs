using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class IssueBooks : Form
    {
        private SqlConnection con; // Kết nối SQL
        private int maxBooksPerStudent = 3; // Số lượng sách tối đa mỗi sinh viên có thể mượn

        public IssueBooks()
        {
            InitializeComponent();
            con = new SqlConnection("data source = LOC-DEP-TRAI\\SQLEXPRESS02; database=LibraryManagement; integrated security=True");
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT bName FROM NewBook", con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    comboBoxBooks.Items.Add(sdr["bName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEnrollement.Text))
            {
                string enroll = txtEnrollement.Text.Trim();

                try
                {
                    con.Open();

                    // Retrieve std_id for the given enrollment number
                    int std_id;
                    using (SqlCommand cmd = new SqlCommand("SELECT stuid FROM NewStudent WHERE enroll = @enroll", con))
                    {
                        cmd.Parameters.AddWithValue("@enroll", enroll);
                        std_id = (int?)cmd.ExecuteScalar() ?? 0;
                    }

                    if (std_id != 0)
                    {
                        // Code to count how many books have been issued to this enrollment number
                        int count;
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(std_id) FROM IRBook WHERE std_id = @std_id AND book_return_date IS NULL", con))
                        {
                            cmd.Parameters.AddWithValue("@std_id", std_id);
                            count = (int)cmd.ExecuteScalar();
                        }

                        if (count < maxBooksPerStudent)
                        {
                            // Retrieve student information
                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM NewStudent WHERE stuid = @std_id", con))
                            {
                                cmd.Parameters.AddWithValue("@std_id", std_id);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    txtName.Text = reader["sname"].ToString();
                                    txtDep.Text = reader["dep"].ToString();
                                    txtSem.Text = reader["sem"].ToString();
                                    txtContact.Text = reader["contact"].ToString();
                                    txtEmail.Text = reader["email"].ToString();
                                }
                                else
                                {
                                    ClearStudentFields();
                                    MessageBox.Show("Invalid Enrollment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                reader.Close();
                            }
                        }
                        else
                        {
                            ClearStudentFields();
                            MessageBox.Show("Student has already borrowed the maximum number of books.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        ClearStudentFields();
                        MessageBox.Show("Invalid Enrollment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1)
                {
                    String enroll = txtEnrollement.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker.Text;

                    con.Open();

                    // Retrieve std_id for the given enrollment number
                    int std_id;
                    using (SqlCommand cmd = new SqlCommand("SELECT stuid FROM NewStudent WHERE enroll = @enroll", con))
                    {
                        cmd.Parameters.AddWithValue("@enroll", enroll);
                        std_id = (int)cmd.ExecuteScalar();
                    }

                    // Retrieve book_id for the given book name
                    int book_id;
                    using (SqlCommand cmd = new SqlCommand("SELECT bid FROM NewBook WHERE bName = @bookname", con))
                    {
                        cmd.Parameters.AddWithValue("@bookname", bookname);
                        book_id = (int)cmd.ExecuteScalar();
                    }

                    // Insert data into IRBook table
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO IRBook (std_id, book_id, book_issue_date) VALUES (@std_id, @book_id, @bookIssueDate)", con))
                    {
                        cmd.Parameters.AddWithValue("@std_id", std_id);
                        cmd.Parameters.AddWithValue("@book_id", book_id);
                        cmd.Parameters.AddWithValue("@bookIssueDate", bookIssueDate);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Select Book. OR maximum number of Books has been Issued.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollement.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollement.Clear();
        }

        private void ClearStudentFields()
        {
            txtName.Clear();
            txtDep.Clear();
            txtSem.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
