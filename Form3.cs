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
    public partial class FormTeacherLogin : Form
    {
        public FormTeacherLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Teachers_Click(object sender, EventArgs e)
        {
            using (DBContext context = new DBContext())
            {
                var teacher = context
                              .Teachers
                              .FirstOrDefault(t => t.TeacherId == int.Parse(textBoxTeacherID_Input.Text));
                if (teacher != null)
                {
                    FormTeacherProfile form = new FormTeacherProfile();
                    FormTeacherProfile.CurrentTeacher = teacher;
                    form.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Няма учител с такова учителско ID!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
