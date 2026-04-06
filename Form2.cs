using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniSystem.Models;

namespace UniSystem
{
    public partial class FormStudentLogin : Form
    {
        public FormStudentLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Students_Click(object sender, EventArgs e)
        {
            using(DBContext context = new DBContext())
            {
                var student = context
                              .Students
                              .FirstOrDefault(s => s.FacultyNumber == textBoxFacultyNumber_Input.Text);
                if (student != null)
                {
                    FormStudentProfile form = new FormStudentProfile();
                    FormStudentProfile.CurrentStudent = student;
                    form.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Няма студент с този факултетен номер!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
