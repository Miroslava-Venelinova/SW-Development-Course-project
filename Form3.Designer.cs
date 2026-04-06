namespace UniSystem
{
    partial class FormTeacherLogin
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
            label2 = new Label();
            textBoxTeacherID_Input = new TextBox();
            buttonLogin_Teachers = new Button();
            buttonCancel_Teachers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(171, 63);
            label1.Name = "label1";
            label1.Size = new Size(382, 28);
            label1.TabIndex = 0;
            label1.Text = "Варненски свободен университет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(96, 153);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 1;
            label2.Text = "Въведете учителско ID:";
            // 
            // textBoxTeacherID_Input
            // 
            textBoxTeacherID_Input.Location = new Point(418, 153);
            textBoxTeacherID_Input.Name = "textBoxTeacherID_Input";
            textBoxTeacherID_Input.Size = new Size(188, 31);
            textBoxTeacherID_Input.TabIndex = 2;
            // 
            // buttonLogin_Teachers
            // 
            buttonLogin_Teachers.BackColor = Color.Teal;
            buttonLogin_Teachers.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogin_Teachers.ForeColor = Color.White;
            buttonLogin_Teachers.Location = new Point(184, 282);
            buttonLogin_Teachers.Name = "buttonLogin_Teachers";
            buttonLogin_Teachers.Size = new Size(112, 34);
            buttonLogin_Teachers.TabIndex = 4;
            buttonLogin_Teachers.Text = "Вход";
            buttonLogin_Teachers.UseVisualStyleBackColor = false;
            buttonLogin_Teachers.Click += buttonLogIn_Teachers_Click;
            // 
            // buttonCancel_Teachers
            // 
            buttonCancel_Teachers.BackColor = Color.Teal;
            buttonCancel_Teachers.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCancel_Teachers.ForeColor = Color.White;
            buttonCancel_Teachers.Location = new Point(427, 282);
            buttonCancel_Teachers.Name = "buttonCancel_Teachers";
            buttonCancel_Teachers.Size = new Size(112, 34);
            buttonCancel_Teachers.TabIndex = 5;
            buttonCancel_Teachers.Text = "Отмени";
            buttonCancel_Teachers.UseVisualStyleBackColor = false;
            buttonCancel_Teachers.Click += buttonCancel_Click;
            // 
            // FormTeacherLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 385);
            Controls.Add(buttonCancel_Teachers);
            Controls.Add(buttonLogin_Teachers);
            Controls.Add(textBoxTeacherID_Input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTeacherLogin";
            Text = "UniSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxTeacherID_Input;
        private Button buttonLogin_Teachers;
        private Button buttonCancel_Teachers;
    }
}