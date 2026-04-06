namespace UniSystem
{
    partial class FormStudentLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxFacultyNumber_Input = new TextBox();
            buttonLogIn_Students = new Button();
            buttonCancel_Students = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(90, 146);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 0;
            label1.Text = "Въведете факултетен номер:";
            // 
            // textBoxFacultyNumber_Input
            // 
            textBoxFacultyNumber_Input.Location = new Point(399, 146);
            textBoxFacultyNumber_Input.Name = "textBoxFacultyNumber_Input";
            textBoxFacultyNumber_Input.Size = new Size(188, 31);
            textBoxFacultyNumber_Input.TabIndex = 1;
            // 
            // buttonLogIn_Students
            // 
            buttonLogIn_Students.BackColor = Color.Teal;
            buttonLogIn_Students.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogIn_Students.ForeColor = Color.White;
            buttonLogIn_Students.Location = new Point(183, 275);
            buttonLogIn_Students.Name = "buttonLogIn_Students";
            buttonLogIn_Students.Size = new Size(112, 34);
            buttonLogIn_Students.TabIndex = 2;
            buttonLogIn_Students.Text = "Вход";
            buttonLogIn_Students.UseVisualStyleBackColor = false;
            buttonLogIn_Students.Click += buttonLogIn_Students_Click;
            // 
            // buttonCancel_Students
            // 
            buttonCancel_Students.BackColor = Color.Teal;
            buttonCancel_Students.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel_Students.ForeColor = Color.White;
            buttonCancel_Students.Location = new Point(382, 275);
            buttonCancel_Students.Name = "buttonCancel_Students";
            buttonCancel_Students.Size = new Size(112, 34);
            buttonCancel_Students.TabIndex = 3;
            buttonCancel_Students.Text = "Отмени";
            buttonCancel_Students.UseVisualStyleBackColor = false;
            buttonCancel_Students.Click += buttonCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(161, 55);
            label3.Name = "label3";
            label3.Size = new Size(382, 28);
            label3.TabIndex = 5;
            label3.Text = "Варненски свободен университет";
            // 
            // FormStudentLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 363);
            Controls.Add(label3);
            Controls.Add(buttonCancel_Students);
            Controls.Add(buttonLogIn_Students);
            Controls.Add(textBoxFacultyNumber_Input);
            Controls.Add(label1);
            Name = "FormStudentLogin";
            Text = "UniSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFacultyNumber_Input;
        private Button buttonLogIn_Students;
        private Button buttonCancel_Students;
        private Label label3;
    }
}