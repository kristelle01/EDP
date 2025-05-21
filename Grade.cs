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
    public partial class Grade : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";

        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        // Call stored procedure
        private void GetStudentGrades(int studenId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("GetStudentGrades", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@studentid", studenId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grades: " + ex.Message);
            }
        }

        private void getgrade_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtstudentID.Text, out int student_Id))
            {
                GetStudentGrades(student_Id);
            }
            else
            {
                MessageBox.Show("Please enter a valid student ID.");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Check for duplicate grade
                    string checkQuery = "SELECT COUNT(*) FROM grades WHERE student_id = @student_id AND subject_id = @subject_id";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@student_id", txtstudentID.Text);
                    checkCmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Grade for this student and subject already exists. Please update it instead.");
                        return;
                    }

                    // Insert if no duplicate
                    string query = "INSERT INTO grades (student_id, subject_id, grade) VALUES (@student_id, @subject_id, @grade)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@student_id", txtstudentID.Text);
                    cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                    cmd.Parameters.AddWithValue("@grade", txtgrade.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Grade added successfully.");
                GetStudentGrades(Convert.ToInt32(txtstudentID.Text));
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding grade: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtstudentID.Text = row.Cells["student_id"].Value.ToString();
                txtsubID.Text = row.Cells["subject_id"].Value.ToString();
                txtgrade.Text = row.Cells["grade"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtstudentID.Text = "";
            txtsubID.Text = "";
            txtgrade.Text = "";
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int gradeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["grade_id"].Value);
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "UPDATE grades SET subject_id=@subject_id, grade=@grade WHERE grade_id=@grade_id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@grade_id", gradeId);
                        cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                        cmd.Parameters.AddWithValue("@grade", txtgrade.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Grade updated successfully.");
                    GetStudentGrades(Convert.ToInt32(txtstudentID.Text));
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating grade: " + ex.Message);
                }
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int gradeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["grade_id"].Value);
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM grades WHERE grade_id=@grade_id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@grade_id", gradeId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Grade deleted successfully.");
                    GetStudentGrades(Convert.ToInt32(txtstudentID.Text));
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting grade: " + ex.Message);
                }
            }
        }
    }
}