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
    public partial class StudentInfo : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";

        public StudentInfo()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }
        private void LoadStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT student_id, first_name, last_name, birth_date, gender, status FROM students";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Format the birth_date column
                    if (dataGridView1.Columns["birth_date"] != null)
                    {
                        dataGridView1.Columns["birth_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }


        private void StudentInfo_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO students (first_name, last_name, birth_date, gender, status) VALUES (@first_name, @last_name, @birth_date, @gender, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                    cmd.Parameters.AddWithValue("@birth_date", txtbirth.Text);
                    cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully.");
                    LoadStudents(); // <- refresh grid after adding
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE students SET first_name=@first_name, last_name=@last_name, birth_date=@birth_date, gender=@gender, status=@status WHERE student_id=@student_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", txtid.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtfname.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtlname.Text);
                    cmd.Parameters.AddWithValue("@birth_date", txtbirth.Text);
                    cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully.");
                    LoadStudents(); // <- refresh grid after updating
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM students WHERE student_id=@student_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", txtid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully.");
                    LoadStudents(); // <- refresh grid after deleting
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent out-of-range errors when clicking header or empty space
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtid.Text = row.Cells["student_id"].Value?.ToString();
                txtfname.Text = row.Cells["first_name"].Value?.ToString();
                txtlname.Text = row.Cells["last_name"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["birth_date"].Value?.ToString(), out DateTime birthDate))
                {
                    txtbirth.Text = birthDate.ToString("yyyy/MM/dd"); // Only date
                }
                else
                {
                    txtbirth.Text = "";
                }
                txtgender.Text = row.Cells["gender"].Value?.ToString();
                txtstatus.Text = row.Cells["status"].Value?.ToString();
            }
        }
    }
}
