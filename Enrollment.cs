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
    public partial class Enrollment : Form
    {
        // ✔️ Update your connection string if needed
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";

        public Enrollment()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            LoadEnrollments(); // ✅ Load data when the form starts
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO enrollments (enrollment_id, student_id, class_id, status) " +
                                   "VALUES (@enrollment_id, @student_id, @class_id, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@enrollment_id", txtenrollmentID.Text.Trim());
                    cmd.Parameters.AddWithValue("@student_id", txtstudentID.Text.Trim());
                    cmd.Parameters.AddWithValue("@class_id", txtclassID.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student enrolled successfully!");

                    // ✅ Refresh the DataGridView
                    LoadEnrollments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error enrolling student: " + ex.Message);
                }
            }
        }

        private void LoadEnrollments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // ✅ Use only table name if already connected to the right DB
                    string query = "SELECT * FROM elem_student_information.enrolled_students;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // ✅ Bind to DataGridView
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load enrollments: " + ex.Message);
                }
            }
        }

        private void btnroll_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO enrollments (student_id, class_id, status) " +
                                   "VALUES (@student_id, @class_id, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", txtstudentID.Text.Trim());
                    cmd.Parameters.AddWithValue("@class_id", txtclassID.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student enrolled successfully!");

                    LoadEnrollments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error enrolling student: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Safely assign values using column indexes
                txtenrollmentID.Text = row.Cells[0].Value?.ToString(); // enrollment_id
                txtstudentID.Text = row.Cells[1].Value?.ToString(); // student_id
                txtclassID.Text = row.Cells[4].Value?.ToString(); // class_id
            }
        }
    }
}
