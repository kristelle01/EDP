using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace elemStudentInfo
{
    public partial class Teachers : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";

        public Teachers()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM teachers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrWhiteSpace(txtlname.Text))
            {
                MessageBox.Show("Please enter required fields.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO teachers (first_name, last_name, subject_id, email, username, password) VALUES (@first_name, @last_name, @subject_id, @email, @username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                    cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Teacher added successfully!");
                ClearFields();
                LoadTeachers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding teacher: " + ex.Message);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtteachID.Text = row.Cells["teacher_id"].Value.ToString();
                txtfname.Text = row.Cells["first_name"].Value.ToString();
                txtlname.Text = row.Cells["last_name"].Value.ToString();
                txtsubID.Text = row.Cells["subject_id"].Value.ToString();
                txtemail.Text = row.Cells["email"].Value.ToString();
                txtusername.Text = row.Cells["username"].Value.ToString();
                txtpass.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtteachID.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtsubID.Text = "";
            txtemail.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtteachID.Text))
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE teachers SET first_name=@first_name, last_name=@last_name, subject_id=@subject_id, email=@email, username=@username, password=@password WHERE teacher_id=@teacher_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@teacher_id", txtteachID.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                    cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Teacher updated successfully!");
                ClearFields();
                LoadTeachers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating teacher: " + ex.Message);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtteachID.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM teachers WHERE teacher_id=@teacher_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@teacher_id", txtteachID.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Teacher deleted successfully!");
                ClearFields();
                LoadTeachers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting teacher: " + ex.Message);
            }
        }
    }
}