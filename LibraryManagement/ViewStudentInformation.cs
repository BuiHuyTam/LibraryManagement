using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void viewStudentInformation_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BHTAM\\SQLEXPRESS; database=LibraryManagement; integrated security=True"; //Thong tin SQL
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].SetValues != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BHTAM\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where stuid = " + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtSName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtContact.Text = DS.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][4].ToString();
            txtSemester.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEnrollment.Text = DS.Tables[0].Rows[0][6].ToString();
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BHTAM\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtSearchEnrollment.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = BHTAM\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                //add data source
                con.ConnectionString = "data source = BHTAM\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete NewStudent where stuid =" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            viewStudentInformation_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String sname = txtSName.Text;
            String enroll = txtEnrollment.Text;
            String dep = txtDepartment.Text;
            String sem = txtSemester.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            String semail = txtEmail.Text;

            if (MessageBox.Show("Data will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                //add data source
                con.ConnectionString = "data source = BHTAM\\SQLEXPRESS; database=LibraryManagement; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname = '" + sname + "', enroll ='" + enroll + "', dep='" + dep + "', sem='" + sem + "', contact='" + contact + "', email='" + semail + "' where stuid =" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved data will be lost.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                this.Close();
            }
        }
    }
}
