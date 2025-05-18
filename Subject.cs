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
    public partial class Subject : Form
    {
        string connectionString = "server=localhost;user id=root;password=mysql123;database=elem_student_information;";

        public Subject()
        {
            InitializeComponent();

            // Hook up event handlers (ensure buttons and grid exist in Designer)
            btnadd.Click += btnadd_Click;
            btnupdate.Click += btnupdate_Click;
            btndelete.Click += btndelete_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            GetSub();
        }

        private void GetSub()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT subject_id AS 'Subject ID', subject_name AS 'Subject Name' FROM subjects";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsubname.Text))
            {
                MessageBox.Show("Please fill in the Subject Name.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    // Do NOT insert subject_id, since it's auto-incremented
                    string query = "INSERT INTO subjects (subject_name) VALUES (@subject_name)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@subject_name", txtsubname.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Subject added successfully!");
                ClearFields();
                GetSub();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding subject: " + ex.Message);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsubID.Text) || string.IsNullOrWhiteSpace(txtsubname.Text))
            {
                MessageBox.Show("Please select a subject and edit its name.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE subjects SET subject_name = @subject_name WHERE subject_id = @subject_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                    cmd.Parameters.AddWithValue("@subject_name", txtsubname.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Subject updated successfully!");
                ClearFields();
                GetSub();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating subject: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsubID.Text))
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this subject?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
                return;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM subjects WHERE subject_id = @subject_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@subject_id", txtsubID.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Subject deleted successfully!");
                ClearFields();
                GetSub();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting subject: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtsubID.Text = row.Cells[0].Value.ToString();
                txtsubname.Text = row.Cells[1].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtsubID.Text = "";
            txtsubname.Text = "";
        }
    }
}

