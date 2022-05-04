using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace LibraryManagement
{
    public partial class IssueBooksForm : Form
    {
        public IssueBooksForm()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillStudent()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Select StudentId from StudentTable", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentId", typeof(int));
            dt.Load(rdr);
            StdCb.ValueMember = "StudentId";
            StdCb.DataSource = dt;
            Conn.Close();
        }
        private void FillBook()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Select BookName from BookTable where Qty>"+0+"", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            Bookcb.ValueMember = "BookName";
            Bookcb.DataSource = dt;
            Conn.Close();
        }

        public void populate()
        {
            Conn.Open();
            string query = "select * from IssueTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IssueBookDataGridView.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void fetchstudentdata()
        {
            Conn.Open();
            string query = "select * from StudentTable where StudentId=" + StdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                stdnameTb.Text = dr["Name"].ToString();
                stddepmntTb.Text = dr["Department"].ToString();
                PhoneTb.Text = dr["Phone"].ToString();
            }
            Conn.Close();
        }
        private void UpdateBook()
        {
            int Qty, newQty;
            Conn.Open();
            string query = "select * from BookTable where BookName='" + Bookcb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty - 1;
                string query1 = "Update BookTable set Qty=" + newQty + "where BookName='" + Bookcb.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Conn);
                cmd1.ExecuteNonQuery();
            }                     
            Conn.Close();
        }
        private void UpdateBookCancellation()
        {
            int Qty, newQty;
            Conn.Open();
            string query = "select * from BookTable where BookName='" + Bookcb.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "Update BookTable set Qty=" + newQty + "where BookName='" + Bookcb.SelectedItem.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Conn);
                cmd1.ExecuteNonQuery();
            }
            Conn.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IssueNumTb.Text == "")
            {
                MessageBox.Show("Enter the Issue Number");
            }
            else
            {
                Conn.Open();
                string query = "delete from IssueTable where IssueNum = " + IssueNumTb.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Issue successfully cancelled");
                Conn.Close();
                //UpdateBookCancellation();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IssueNumTb.Text == "" || stdnameTb.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                string issuedate = IssueDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into IssueTable values(" + IssueNumTb.Text + "," + StdCb.SelectedValue.ToString() + ",'" + stdnameTb.Text + "','" + stddepmntTb.Text + "','" + PhoneTb.Text + "','" + Bookcb.SelectedValue.ToString() + "','" + issuedate + "')", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Issued");
                Conn.Close();
                UpdateBook();
                populate();
            }
        }

        private void IssueBooksForm_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            populate();
        }

        private void StdCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void StdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstudentdata();
        }

        private void StdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IssueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IssueBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueNumTb.Text = IssueBookDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            StdCb.Text = IssueBookDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            stdnameTb.Text = IssueBookDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            stddepmntTb.Text = IssueBookDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = IssueBookDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Bookcb.Text = IssueBookDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
