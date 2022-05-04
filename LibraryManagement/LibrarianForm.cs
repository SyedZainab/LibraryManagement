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
    public partial class LibrarianForm : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Conn.Open();
            string query = "select * from LibrarianTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDataGridView.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into LibrarianTable values(" + LibId.Text + ",'" + LibName.Text + "','" + Libpass.Text + "','" + Libphone.Text + "')", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian added successfully");
                Conn.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "")
            {
                MessageBox.Show("Enter the Librarian Id");
            }
            else
            {
                Conn.Open();
                string query = "delete from LibrarianTable where LibId = " + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian successfully deleted");
                Conn.Close();
                populate();
            }
        }

        private void LibrarianDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LibId.Text = LibrarianDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            LibName.Text = LibrarianDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Libpass.Text = LibrarianDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Libphone.Text = LibrarianDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(LibId.Text == "" || LibName.Text == "" || Libpass.Text == "" || Libphone.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                Conn.Open();
                string query = "update LibrarianTable set LibName='" + LibName.Text + "',LibPassword='" + Libpass.Text + "',LibPhone='"+Libphone.Text+"' where LibId=" + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian successfully Updated");
                Conn.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
