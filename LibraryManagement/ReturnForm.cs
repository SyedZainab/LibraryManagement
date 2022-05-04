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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
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
        public void populatereturn()
        {
            Conn.Open();
            string query = "select * from ReturnTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnBookDataGridView.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
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
                newQty = Qty + 1;
                string query1 = "Update BookTable set Qty=" + newQty + "where BookName='" + Bookcb.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Conn);
                cmd1.ExecuteNonQuery();
            }
            Conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ReturnNumTb.Text == "" || stdnameTb.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                string issuedate = IssueDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();
                string returndate = ReturnDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ReturnTable values(" + ReturnNumTb.Text + "," + StdCb.SelectedItem.ToString() + ",'" + stdnameTb.Text + "','" + stddepmntTb.Text + "','" + PhoneTb.Text + "','" + Bookcb.SelectedValue.ToString() + "','" + issuedate + "','"+returndate+"')", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Returned");
                Conn.Close();
                UpdateBook();
                populate();
                populatereturn();
            }
        }
        

        private void FillBook()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("Select BookName from BookTable where Qty>" + 0 + "", Conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            Bookcb.ValueMember = "BookName";
            Bookcb.DataSource = dt;
            Conn.Close();
        }
        private void ReturnForm_Load(object sender, EventArgs e)
        {
            populate();
            populatereturn();
            FillBook();
        }

        private void IssueBookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdCb.Text = ReturnBookDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            stdnameTb.Text = ReturnBookDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            stddepmntTb.Text = ReturnBookDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = ReturnBookDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Bookcb.Text = ReturnBookDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
