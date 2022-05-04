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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Mylibrarydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || Stdphone.Text == "" || Stdsem.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                Conn.Open();
                string query = "update StudentTable set Name='" + StdName.Text + "',Department='" + StdDep.Text + "',Sem=" + Stdsem.SelectedItem.ToString() +",Phone='"+ Stdphone.Text+"' where StudentId=" + StdId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student successfully Updated");
                Conn.Close();
                populate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            Conn.Open();
            string query = "select * from StudentTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDataGridView.DataSource = ds.Tables[0];
            Conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || Stdphone.Text == "" || Stdsem.Text == "")
            {
                MessageBox.Show("Enter all the details");
            }
            else
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTable values(" + StdId.Text + ",'" + StdName.Text + "','" + StdDep.Text + "'," + Stdsem.SelectedItem.ToString() + ",'"+Stdphone.Text+"')", Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully");
                Conn.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "")
            {
                MessageBox.Show("Enter the Student Id");
            }
            else
            {
                Conn.Open();
                string query = "delete from StudentTable where StudentId = " + StdId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student successfully deleted");
                Conn.Close();
                populate();
            }
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId.Text = StudentDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            StdName.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            StdDep.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Stdsem.SelectedItem = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Stdphone.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
