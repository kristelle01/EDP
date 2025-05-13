using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuiForDentalA;
using MySql.Data.MySqlClient;

namespace elemStudentInfo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseHelper.TestDatabaseConnection();
            this.forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpass_LinkClicked);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = frmusername.Text.Trim();
            string password = frmpassword.Text.Trim();

            try
            {
                MySqlConnection conn = DatabaseHelper.GetConnection(); // DO NOT wrap in `using`

                string query = "SELECT * FROM elem_student_information.teachers WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        // Update this depending on actual column name
                        string roleId = reader["teacher_id"].ToString();

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dashboard adminForm = new Dashboard();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                DatabaseHelper.CloseConnection(); // Close manually AFTER reader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                frmpassword.UseSystemPasswordChar = false; // Show characters
            }
            else
            {
                frmpassword.UseSystemPasswordChar = true;  // Mask characters
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch all patients and display in DataGridView
                string query = "SELECT * FROM students";
                using (var reader = DatabaseHelper.ExecuteQuery(query))
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string inputUsername = Microsoft.VisualBasic.Interaction.InputBox("Enter your username:", "Forgot Password");
            if (string.IsNullOrWhiteSpace(inputUsername))
                return;

            string inputEmail = Microsoft.VisualBasic.Interaction.InputBox("Enter your email:", "Forgot Password");
            if (string.IsNullOrWhiteSpace(inputEmail))
                return;

            try
            {
                MySqlConnection conn = DatabaseHelper.GetConnection(); // Do NOT use 'using'

                string query = "SELECT password FROM elem_student_information.teachers WHERE username = @username AND email = @email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", inputUsername);
                cmd.Parameters.AddWithValue("@email", inputEmail);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string password = result.ToString();
                    MessageBox.Show($"Your password is: {password}", "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching user found. Please check your username and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
