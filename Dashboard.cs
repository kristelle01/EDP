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

namespace elemStudentInfo
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DatabaseHelper.TestDatabaseConnection();
        }

        private void studentInfo_Click(object sender, EventArgs e)
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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {

        }
    }
}
