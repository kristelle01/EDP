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
    public partial class Class : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";
        int selectedClassId = -1;

        public Class()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            LoadClasses();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }

        private void LoadClasses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM classes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void ClearFields()
        {
            txtclassname.Clear();
            txtteachID.Clear();
            txtsubID.Clear();
            selectedClassId = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO classes (class_name, teacher_id, subject_id) VALUES (@class_name, @teacher_id, @subject_id)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@class_name", txtclassname.Text);
                cmd.Parameters.AddWithValue("@teacher_id", txtteachID.Text);
                cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                cmd.ExecuteNonQuery();
                LoadClasses();
                ClearFields();
                MessageBox.Show("Class added successfully.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedClassId < 0)
            {
                MessageBox.Show("Please select a class to update.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE classes SET class_name = @class_name, teacher_id = @teacher_id, subject_id = @subject_id WHERE class_id = @class_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@class_name", txtclassname.Text);
                cmd.Parameters.AddWithValue("@teacher_id", txtteachID.Text);
                cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                cmd.Parameters.AddWithValue("@class_id", selectedClassId);
                cmd.ExecuteNonQuery();
                LoadClasses();
                ClearFields();
                MessageBox.Show("Class updated successfully.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedClassId < 0)
            {
                MessageBox.Show("Please select a class to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this class?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM classes WHERE class_id = @class_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@class_id", selectedClassId);
                    cmd.ExecuteNonQuery();
                    LoadClasses();
                    ClearFields();
                    MessageBox.Show("Class deleted successfully.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assign selected class ID for update/delete
                selectedClassId = Convert.ToInt32(row.Cells["class_id"].Value);

                txtclassID.Text = row.Cells["class_id"].Value?.ToString();
                txtclassname.Text = row.Cells["class_name"].Value?.ToString();
                txtteachID.Text = row.Cells["teacher_id"].Value?.ToString();
                txtsubID.Text = row.Cells["subject_id"].Value?.ToString();
            }
        }

    }
}