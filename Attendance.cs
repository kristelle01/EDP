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
using MySqlX.XDevAPI.Relational;

namespace elemStudentInfo
{
    public partial class Attendance : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";
        int selectedAttendanceId = -1;
        private DataTable attendanceTable; // Holds all attendance records


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
                attendanceTable = new DataTable();
                adapter.Fill(attendanceTable);
                dataGridView1.DataSource = attendanceTable;
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
            txtattDate.Clear();
            selectedAttendanceId = -1;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
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
                    cmd.Parameters.AddWithValue("@attendance_date", txtattDate.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.ExecuteNonQuery();

                    LoadAttendance();
                    ClearFields();
                    MessageBox.Show("Attendance record added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding record: " + ex.Message);
                }
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
                try
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
                    cmd.Parameters.AddWithValue("@attendance_date", txtattDate.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@attendance_id", selectedAttendanceId);
                    cmd.ExecuteNonQuery();

                    LoadAttendance();
                    ClearFields();
                    MessageBox.Show("Attendance record updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
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
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedAttendanceId = Convert.ToInt32(row.Cells["attendance_id"].Value);
                txtattendanceID.Text = row.Cells["attendance_id"].Value.ToString();
                txtstudentID.Text = row.Cells["student_id"].Value.ToString();
                txtstuname.Text = row.Cells["student_name"].Value.ToString();
                txtclassID.Text = row.Cells["class_id"].Value.ToString();
                txtclassname.Text = row.Cells["class_name"].Value.ToString();

                if (row.Cells["attendance_date"].Value != DBNull.Value)
                {
                    txtattDate.Text = Convert.ToDateTime(row.Cells["attendance_date"].Value).ToString("yyyy-MM-dd");
                }

                txtstatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void comboFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attendanceTable == null) return;

            string selectedStatus = comboFilterStatus.SelectedItem.ToString();

            if (selectedStatus == "All")
            {
                attendanceTable.DefaultView.RowFilter = string.Empty; // Show all records
            }
            else
            {
                // Filter the DataTable to show only records with selected status
                attendanceTable.DefaultView.RowFilter = $"status = '{selectedStatus}'";
            }
        }
    }
}