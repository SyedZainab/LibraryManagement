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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from BookTable", Conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Booklbl.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from StudentTable", Conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Studentlbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from LibrarianTable", Conn);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            Librarianlbl.Text = dt3.Rows[0][0].ToString();

            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from IssueTable", Conn);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            IssuedBookslbl.Text = dt4.Rows[0][0].ToString();

            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from ReturnTable", Conn);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            ReturnedBookslbl.Text = dt5.Rows[0][0].ToString();
            Conn.Close();
        }
    }
}
