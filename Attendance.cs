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
    public partial class Attendance : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";
        int selectedAttendanceId = -1;
        private DateTimePicker dateTimePicker1;

        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadAttendance();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadAttendance()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM attendance";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void ClearFields()
        {
            txtattendanceID.Clear();
            txtstudentID.Clear();
            txtstuname.Clear();
            txtclassID.Clear();
            txtclassname.Clear();
            txtstatus.Clear();
            dateTimePicker1.Value = DateTime.Now;
            selectedAttendanceId = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO attendance 
                                (student_id, student_name, class_id, class_name, attendance_date, status) 
                                VALUES 
                                (@student_id, @student_name, @class_id, @class_name, @attendance_date, @status)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@student_id", txtstudentID.Text);
                cmd.Parameters.AddWithValue("@student_name", txtstuname.Text);
                cmd.Parameters.AddWithValue("@class_id", txtclassID.Text);
                cmd.Parameters.AddWithValue("@class_name", txtclassname.Text);
                cmd.Parameters.AddWithValue("@attendance_date", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                cmd.ExecuteNonQuery();

                LoadAttendance();
                ClearFields();
                MessageBox.Show("Attendance record added successfully.");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId < 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE attendance SET 
                                student_id = @student_id,
                                student_name = @student_name,
                                class_id = @class_id,
                                class_name = @class_name,
                                attendance_date = @attendance_date,
                                status = @status 
                                WHERE attendance_id = @attendance_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@student_id", txtstudentID.Text);
                cmd.Parameters.AddWithValue("@student_name", txtstuname.Text);
                cmd.Parameters.AddWithValue("@class_id", txtclassID.Text);
                cmd.Parameters.AddWithValue("@class_name", txtclassname.Text);
                cmd.Parameters.AddWithValue("@attendance_date", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                cmd.Parameters.AddWithValue("@attendance_id", selectedAttendanceId);
                cmd.ExecuteNonQuery();

                LoadAttendance();
                ClearFields();
                MessageBox.Show("Attendance record updated successfully.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId < 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM attendance WHERE attendance_id = @attendance_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@attendance_id", selectedAttendanceId);
                    cmd.ExecuteNonQuery();

                    LoadAttendance();
                    ClearFields();
                    MessageBox.Show("Record deleted successfully.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                try
                {
                    // Index-based mapping (make sure this matches your column order in DB)
                    txtattendanceID.Text = row.Cells[0].Value?.ToString();
                    txtstudentID.Text = row.Cells[1].Value?.ToString();
                    txtstuname.Text = row.Cells[5].Value?.ToString();
                    txtclassID.Text = row.Cells[2].Value?.ToString();
                    txtclassname.Text = row.Cells[6].Value?.ToString();

                    // Safe DateTime parsing
                    if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime date))
                    {
                        dateTimePicker1.Value = date;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now;
                    }

                    txtstatus.Text = row.Cells[4].Value?.ToString();

                    // Store selected ID
                    selectedAttendanceId = Convert.ToInt32(row.Cells[0].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
    }
}
