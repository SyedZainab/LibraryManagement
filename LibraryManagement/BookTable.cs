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
    public partial class BookTable : Form
    {
        public BookTable()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookTable_Load(object sender, EventArgs e)
        {
            populate();
        }

        public void populate()
        {
            Conn.Open();
            string query = "select * from BookTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookDataGridView.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "" || author.Text == "" || publisher.Text == "" || price.Text == "" || Qty.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into BookTable values('" + bookname.Text + "','" + author.Text + "','" + publisher.Text + "'," + price.Text + "," + Qty.Text + ")", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added successfully");
                Conn.Close();
                populate();
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookname.Text = BookDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            author.Text = BookDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            publisher.Text = BookDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = BookDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Qty.Text = BookDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "")
            {
                MessageBox.Show("Enter the Book Id");
            }
            else
            {
                Conn.Open();
                string query = "delete from BookTable where BookName = '" + bookname.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully deleted");
                Conn.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bookname.Text == "" || author.Text == "" || publisher.Text == "" || price.Text == "" || Qty.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                Conn.Open();
                string query = "update BookTable set Author='" + author.Text + "',Publisher='" + publisher.Text + "',Price=" + price.Text + ",Qty=" + Qty.Text + " where BookName='" + bookname.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully Updated");
                Conn.Close();
                populate();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
