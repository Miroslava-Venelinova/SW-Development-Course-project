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
    public partial class FormStudentProfile : Form
    {
        public FormStudentProfile()
        {
            InitializeComponent();
        }

        public static Student CurrentStudent { get; set; } = new Student();

        private void toolStripButtonFees_Click(object sender, EventArgs e)
        {
            groupBoxFees.Visible = true;
            groupBoxGrades.Visible = false;
            groupBoxStudentProfile.Visible = false;

            textBoxUnpaidFees.Text = CurrentStudent.UnpaidFees.ToString();
        }

        private void toolStripButtonGrades_Click(object sender, EventArgs e)
        {
            groupBoxGrades.Visible = true;
            groupBoxFees.Visible = false;
            groupBoxStudentProfile.Visible = false;

            textBoxAverageGrade.Text = CurrentStudent.AverageGrade.ToString();

            using (DBContext context = new DBContext())
            {
                var studentSubjects = (
                    from sub in context.Subjects
                    join studSub in context.StudentsSubjects
                        on sub.SubjectId equals studSub.Subject
                    where studSub.Student == CurrentStudent.FacultyNumber
                    select new
                    {
                        subject_name = sub.SubjectName
                    }
                 ).ToList();

                dataGridView1.DataSource = studentSubjects;

                var studentGrades = (
                    from g in context.Grades
                    join sub in context.Subjects
                        on g.SubjectId equals sub.SubjectId
                    join t in context.Teachers
                        on g.TeacherId equals t.TeacherId
                    where g.StudentId == CurrentStudent.FacultyNumber
                    select new
                    {
                        grade_id = g.GradeId,
                        grade_entrydate = g.EntryDate,
                        grade_value = g.GradeValue,
                        subject_name = sub.SubjectName,
                        teacher_firstName = t.FirstName,
                        teacher_lastName = t.LastName
                    }
                ).ToList();

                dataGridView2.DataSource = studentGrades;
            }
        }

        private void toolStripButtonProfile_Click(object sender, EventArgs e)
        {
            groupBoxGrades.Visible = false;
            groupBoxFees.Visible = false;
            groupBoxStudentProfile.Visible = true;

            textBoxFacultyNumber.Text = CurrentStudent.FacultyNumber.ToString();

            textBoxFirstName.Text = CurrentStudent.FirstName;
            textBoxMiddleName.Text = CurrentStudent.MiddleName;
            textBoxLastName.Text = CurrentStudent.LastName;

            using (DBContext context = new DBContext())
            {
                var address = context.Addresses.First(a => a.AddressId == CurrentStudent.Address);
                textBoxAddressCity.Text = address.City.ToString();
                textBoxAddressStreet.Text = address.Street.ToString();

                var major = context.Majors.First(m => m.MajorId == CurrentStudent.Major);
                textBoxMajor.Text = major.MajorName;
            }
            textBoxDegreeType.Text = CurrentStudent.DegreeType;
            textBoxStream.Text = CurrentStudent.Stream.ToString();
            textBoxGroup.Text = CurrentStudent.Group.ToString();
            textBoxEnrollmentDate.Text = CurrentStudent.EnrollmentDate.ToString();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormStart form = new FormStart();
            form.Show();
            this.Close();
        }
    }
}
