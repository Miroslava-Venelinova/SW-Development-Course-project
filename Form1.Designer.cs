namespace UniSystem
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonStudentMode = new Button();
            buttonTeacherMode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vsu;
            pictureBox1.Location = new Point(21, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(780, 335);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(837, 84);
            label1.Name = "label1";
            label1.Size = new Size(394, 28);
            label1.TabIndex = 1;
            label1.Text = "Добре дошли в системата на ВСУ!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(901, 174);
            label2.Name = "label2";
            label2.Size = new Size(239, 28);
            label2.TabIndex = 2;
            label2.Text = "Моля, изберете роля:";
            // 
            // buttonStudentMode
            // 
            buttonStudentMode.BackColor = Color.Teal;
            buttonStudentMode.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStudentMode.ForeColor = Color.White;
            buttonStudentMode.Location = new Point(858, 274);
            buttonStudentMode.Name = "buttonStudentMode";
            buttonStudentMode.Size = new Size(112, 34);
            buttonStudentMode.TabIndex = 3;
            buttonStudentMode.Text = "Студент";
            buttonStudentMode.UseVisualStyleBackColor = false;
            buttonStudentMode.Click += buttonStudentMode_Click;
            // 
            // buttonTeacherMode
            // 
            buttonTeacherMode.BackColor = Color.Teal;
            buttonTeacherMode.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonTeacherMode.ForeColor = Color.White;
            buttonTeacherMode.Location = new Point(1089, 274);
            buttonTeacherMode.Name = "buttonTeacherMode";
            buttonTeacherMode.Size = new Size(112, 34);
            buttonTeacherMode.TabIndex = 4;
            buttonTeacherMode.Text = "Учител";
            buttonTeacherMode.UseVisualStyleBackColor = false;
            buttonTeacherMode.Click += buttonTeacherMode_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 383);
            Controls.Add(buttonTeacherMode);
            Controls.Add(buttonStudentMode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormStart";
            Text = "UniSystem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button buttonStudentMode;
        private Button buttonTeacherMode;
    }
}
