using UniSystem.Models;

namespace UniSystem
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonStudentMode_Click(object sender, EventArgs e)
        {
            FormStudentLogin form = new FormStudentLogin();
            form.Show();
            this.Hide();
        }

        private void buttonTeacherMode_Click(object sender, EventArgs e)
        {
            FormTeacherLogin form = new FormTeacherLogin();
            form.Show();
            this.Hide();
        }
    }
}
