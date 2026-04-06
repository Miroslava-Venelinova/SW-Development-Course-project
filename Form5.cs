using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using UniSystem.Models;

namespace UniSystem
{
    public partial class FormTeacherProfile : Form
    {
        public FormTeacherProfile()
        {
            InitializeComponent();
        }

        public static Teacher CurrentTeacher { get; set; } = new Teacher();

        private void toolStripButtonProfile_Click(object sender, EventArgs e)
        {
            groupBoxProfile.Visible = true;
            groupBoxSearches.Visible = false;
            groupBoxGrading.Visible = false;

            textBox1.Text = CurrentTeacher.TeacherId.ToString();
            textBox2.Text = CurrentTeacher.FirstName;
            textBox3.Text = CurrentTeacher.LastName;

            using (DBContext context = new DBContext())
            {
                var teacherSubjects = (
                    from s in context.Subjects
                    join ts in context.TeachersSubjects
                        on s.SubjectId equals ts.Subject
                    where ts.Teacher == CurrentTeacher.TeacherId
                    select s
                ).ToList();

                dataGridView1.DataSource = teacherSubjects;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormStart form = new FormStart();
            form.Show();
            this.Close();
        }

        private void toolStripButtonSearches_Click(object sender, EventArgs e)
        {
            groupBoxSearches.Visible = true;
            groupBoxProfile.Visible = false;
            groupBoxGrading.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var item = comboBoxOptions.SelectedItem.ToString();

            switch (item)
            {
                case "Студент по имена":
                    using (DBContext context = new DBContext())
                    {
                        List<string> names = textBoxInput.Text.Split(' ').ToList();

                        var student = context.Students.Where(
                            s => s.FirstName == names[0] &&
                                 s.MiddleName == names[1] &&
                                 s.LastName == names[2]).ToList();
                        dataGridView2.DataSource = student;
                    }
                    break;
                case "Студент по фак. номер":
                    using (DBContext context = new DBContext())
                    {
                        var facultyNumber = textBoxInput.Text;

                        var student = context.Students.Where(
                            s => s.FacultyNumber == facultyNumber).ToList();
                        dataGridView2.DataSource = student;
                    }
                    break;
                case "Студент по изучаван предмет":
                    using (DBContext context = new DBContext())
                    {
                        var subjectId = int.Parse(textBoxInput.Text);

                        var students = (
                            from s in context.Students
                            join s_sub in context.StudentsSubjects
                                on s.FacultyNumber equals s_sub.Student
                            join sub in context.Subjects
                                on s_sub.Subject equals sub.SubjectId
                            where s_sub.Subject == subjectId
                            select s
                        ).ToList();

                        dataGridView2.DataSource = students;
                    }
                    break;
                case "Студент по ср. успех":
                    using (DBContext context = new DBContext())
                    {
                        var averageGrade = decimal.Parse(textBoxInput.Text);

                        var students = context.Students.Where(
                            s => s.AverageGrade == averageGrade).ToList();

                        dataGridView2.DataSource = students;
                    }
                    break;
                case "Студенти с над 1000 лв. неплатени такси":
                    using (DBContext context = new DBContext())
                    {
                        var students = context.Students.Where(
                            s => s.UnpaidFees > 1000).ToList();
                        dataGridView2.DataSource = students;
                    }
                    break;
                case "Списък с всички оценки на студент":
                    using (DBContext context = new DBContext())
                    {
                        var facultyNumber = textBoxInput.Text;

                        var student = context.Grades.Where(
                            g => g.StudentId == facultyNumber).ToList();

                        dataGridView2.DataSource = student;
                    }
                    break;

                case "Среден успех на студентите":
                    using (DBContext context = new DBContext())
                    {
                        var averageGrades = (
                            from s in context.Students
                            join s_sub in context.StudentsSubjects
                                on s.FacultyNumber equals s_sub.Student
                            join sub in context.Subjects
                                on s_sub.Subject equals sub.SubjectId
                            join t_sub in context.TeachersSubjects
                                on s_sub.Subject equals t_sub.Subject
                            join t in context.Teachers
                                on t_sub.Teacher equals t.TeacherId
                            where t.TeacherId == CurrentTeacher.TeacherId
                            select s.AverageGrade
                            ).ToList();

                        textBoxInput.Text = averageGrades.Average().ToString();
                    }
                    break;
                case "Брой оценки от даден период":
                    using (DBContext context = new DBContext())
                    {
                        var entryRange = textBoxInput.Text.Split(' ').Select(DateTime.Parse).ToList();

                        var grades = context.Grades.Where(g => g.EntryDate >= entryRange[0]
                                        && g.EntryDate <= entryRange[1]).ToList();

                        textBoxInput.Text = grades.Count().ToString();
                    }
                    break;
                case "Последни 10 записани студенти":
                    using (DBContext context = new DBContext())
                    {
                        var lastEnrolled = context.Students.OrderBy(s => s.EnrollmentDate).Take(10).ToList();
                        dataGridView2.DataSource = lastEnrolled;
                    }
                    break;

            }
        }

        private void toolStripButtonGrading_Click(object sender, EventArgs e)
        {
            groupBoxProfile.Visible = false;
            groupBoxSearches.Visible = false;
            groupBoxGrading.Visible = true;
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            using (DBContext context = new DBContext())
            {

                Grade grade = new Grade()
                {
                    EntryDate = DateTime.Parse(textBoxEntryDate.Text),
                    Student = context.Students.First(s => s.FacultyNumber == textBoxFacultyNumber.Text),
                    Teacher = CurrentTeacher,
                    Subject = context.Subjects.First(s => s.SubjectId == int.Parse(textBoxSubject.Text)),
                    GradeValue = decimal.Parse(textBoxGradeValue.Text)
                };

                // context.Grades.InsertOnSubmit(grade);
                // context.SubmitChanges();
            }
            MessageBox.Show("Оценката беше вписана успешно!");
        }
    }
}

