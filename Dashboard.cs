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
            StudentInfo si = new StudentInfo();
            si.ShowDialog(); // Open the StudentInfo form modally
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enrollment si = new Enrollment();
            si.ShowDialog(); // Open the StudentInfo form modally
        }

        private void subject_Click(object sender, EventArgs e)
        {
            Subject si = new Subject();
            si.ShowDialog(); // Open the StudentInfo form modally
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            Teachers si = new Teachers();
            si.ShowDialog();
        }
    }
}
