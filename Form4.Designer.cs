namespace UniSystem
{
    partial class FormStudentProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentProfile));
            toolStrip1 = new ToolStrip();
            toolStripButtonProfile = new ToolStripButton();
            toolStripButtonGrades = new ToolStripButton();
            toolStripButtonFees = new ToolStripButton();
            groupBoxFees = new GroupBox();
            textBoxUnpaidFees = new TextBox();
            label1 = new Label();
            groupBoxGrades = new GroupBox();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            textBoxAverageGrade = new TextBox();
            label2 = new Label();
            groupBoxStudentProfile = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            buttonLogOut = new Button();
            textBoxEnrollmentDate = new TextBox();
            textBoxGroup = new TextBox();
            textBoxStream = new TextBox();
            textBoxDegreeType = new TextBox();
            textBoxMajor = new TextBox();
            textBoxAddressStreet = new TextBox();
            textBoxAddressCity = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMiddleName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxFacultyNumber = new TextBox();
            toolStrip1.SuspendLayout();
            groupBoxFees.SuspendLayout();
            groupBoxGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxStudentProfile.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonProfile, toolStripButtonGrades, toolStripButtonFees });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1024, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonProfile
            // 
            toolStripButtonProfile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonProfile.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripButtonProfile.ForeColor = Color.Teal;
            toolStripButtonProfile.Image = (Image)resources.GetObject("toolStripButtonProfile.Image");
            toolStripButtonProfile.ImageTransparentColor = Color.Magenta;
            toolStripButtonProfile.Name = "toolStripButtonProfile";
            toolStripButtonProfile.Size = new Size(93, 29);
            toolStripButtonProfile.Text = "Профил";
            toolStripButtonProfile.Click += toolStripButtonProfile_Click;
            // 
            // toolStripButtonGrades
            // 
            toolStripButtonGrades.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonGrades.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripButtonGrades.ForeColor = Color.Teal;
            toolStripButtonGrades.Image = (Image)resources.GetObject("toolStripButtonGrades.Image");
            toolStripButtonGrades.ImageTransparentColor = Color.Magenta;
            toolStripButtonGrades.Name = "toolStripButtonGrades";
            toolStripButtonGrades.Size = new Size(86, 29);
            toolStripButtonGrades.Text = "Оценки";
            toolStripButtonGrades.Click += toolStripButtonGrades_Click;
            // 
            // toolStripButtonFees
            // 
            toolStripButtonFees.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonFees.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripButtonFees.ForeColor = Color.Teal;
            toolStripButtonFees.Image = (Image)resources.GetObject("toolStripButtonFees.Image");
            toolStripButtonFees.ImageTransparentColor = Color.Magenta;
            toolStripButtonFees.Name = "toolStripButtonFees";
            toolStripButtonFees.Size = new Size(69, 29);
            toolStripButtonFees.Text = "Такси";
            toolStripButtonFees.Click += toolStripButtonFees_Click;
            // 
            // groupBoxFees
            // 
            groupBoxFees.Controls.Add(textBoxUnpaidFees);
            groupBoxFees.Controls.Add(label1);
            groupBoxFees.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxFees.ForeColor = Color.Teal;
            groupBoxFees.Location = new Point(40, 56);
            groupBoxFees.Name = "groupBoxFees";
            groupBoxFees.Size = new Size(923, 479);
            groupBoxFees.TabIndex = 1;
            groupBoxFees.TabStop = false;
            groupBoxFees.Text = "Семестриални такси";
            // 
            // textBoxUnpaidFees
            // 
            textBoxUnpaidFees.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUnpaidFees.Location = new Point(384, 73);
            textBoxUnpaidFees.Name = "textBoxUnpaidFees";
            textBoxUnpaidFees.Size = new Size(150, 34);
            textBoxUnpaidFees.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 73);
            label1.Name = "label1";
            label1.Size = new Size(323, 28);
            label1.TabIndex = 0;
            label1.Text = "Дължими семестирални такси:";
            // 
            // groupBoxGrades
            // 
            groupBoxGrades.Controls.Add(dataGridView2);
            groupBoxGrades.Controls.Add(dataGridView1);
            groupBoxGrades.Controls.Add(label4);
            groupBoxGrades.Controls.Add(label3);
            groupBoxGrades.Controls.Add(textBoxAverageGrade);
            groupBoxGrades.Controls.Add(label2);
            groupBoxGrades.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxGrades.ForeColor = Color.Teal;
            groupBoxGrades.Location = new Point(40, 56);
            groupBoxGrades.Name = "groupBoxGrades";
            groupBoxGrades.Size = new Size(923, 479);
            groupBoxGrades.TabIndex = 2;
            groupBoxGrades.TabStop = false;
            groupBoxGrades.Text = "Студентски оценки";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(419, 143);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(478, 317);
            dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 89);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 5;
            label4.Text = "Оценки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 89);
            label3.Name = "label3";
            label3.Size = new Size(218, 28);
            label3.TabIndex = 4;
            label3.Text = "Изучавани предмети:";
            // 
            // textBoxAverageGrade
            // 
            textBoxAverageGrade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAverageGrade.Location = new Point(747, 41);
            textBoxAverageGrade.Name = "textBoxAverageGrade";
            textBoxAverageGrade.Size = new Size(150, 31);
            textBoxAverageGrade.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(537, 41);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 0;
            label2.Text = "Среден успех:";
            // 
            // groupBoxStudentProfile
            // 
            groupBoxStudentProfile.Controls.Add(label12);
            groupBoxStudentProfile.Controls.Add(label11);
            groupBoxStudentProfile.Controls.Add(label10);
            groupBoxStudentProfile.Controls.Add(label9);
            groupBoxStudentProfile.Controls.Add(label8);
            groupBoxStudentProfile.Controls.Add(label7);
            groupBoxStudentProfile.Controls.Add(label6);
            groupBoxStudentProfile.Controls.Add(label5);
            groupBoxStudentProfile.Controls.Add(buttonLogOut);
            groupBoxStudentProfile.Controls.Add(textBoxEnrollmentDate);
            groupBoxStudentProfile.Controls.Add(textBoxGroup);
            groupBoxStudentProfile.Controls.Add(textBoxStream);
            groupBoxStudentProfile.Controls.Add(textBoxDegreeType);
            groupBoxStudentProfile.Controls.Add(textBoxMajor);
            groupBoxStudentProfile.Controls.Add(textBoxAddressStreet);
            groupBoxStudentProfile.Controls.Add(textBoxAddressCity);
            groupBoxStudentProfile.Controls.Add(textBoxLastName);
            groupBoxStudentProfile.Controls.Add(textBoxMiddleName);
            groupBoxStudentProfile.Controls.Add(textBoxFirstName);
            groupBoxStudentProfile.Controls.Add(textBoxFacultyNumber);
            groupBoxStudentProfile.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxStudentProfile.ForeColor = Color.Teal;
            groupBoxStudentProfile.Location = new Point(40, 56);
            groupBoxStudentProfile.Name = "groupBoxStudentProfile";
            groupBoxStudentProfile.Size = new Size(923, 479);
            groupBoxStudentProfile.TabIndex = 8;
            groupBoxStudentProfile.TabStop = false;
            groupBoxStudentProfile.Text = "Информация за студента";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(83, 377);
            label12.Name = "label12";
            label12.Size = new Size(168, 25);
            label12.TabIndex = 19;
            label12.Text = "Дата на записване";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(686, 250);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 18;
            label11.Text = "Група";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(513, 247);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 17;
            label10.Text = "Поток";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(337, 247);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 16;
            label9.Text = "ОКС";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(82, 244);
            label8.Name = "label8";
            label8.Size = new Size(134, 28);
            label8.TabIndex = 15;
            label8.Text = "Специалност";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 177);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 14;
            label7.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 115);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 13;
            label6.Text = "Имена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 64);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 12;
            label5.Text = "фак. №";
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Teal;
            buttonLogOut.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(782, 43);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(112, 34);
            buttonLogOut.TabIndex = 11;
            buttonLogOut.Text = "Изход";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // textBoxEnrollmentDate
            // 
            textBoxEnrollmentDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEnrollmentDate.Location = new Point(268, 377);
            textBoxEnrollmentDate.Name = "textBoxEnrollmentDate";
            textBoxEnrollmentDate.Size = new Size(309, 34);
            textBoxEnrollmentDate.TabIndex = 10;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGroup.Location = new Point(691, 290);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(150, 34);
            textBoxGroup.TabIndex = 9;
            // 
            // textBoxStream
            // 
            textBoxStream.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxStream.Location = new Point(512, 290);
            textBoxStream.Name = "textBoxStream";
            textBoxStream.Size = new Size(150, 34);
            textBoxStream.TabIndex = 8;
            // 
            // textBoxDegreeType
            // 
            textBoxDegreeType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDegreeType.Location = new Point(337, 288);
            textBoxDegreeType.Name = "textBoxDegreeType";
            textBoxDegreeType.Size = new Size(150, 34);
            textBoxDegreeType.TabIndex = 7;
            // 
            // textBoxMajor
            // 
            textBoxMajor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMajor.Location = new Point(82, 288);
            textBoxMajor.Name = "textBoxMajor";
            textBoxMajor.Size = new Size(210, 34);
            textBoxMajor.TabIndex = 6;
            // 
            // textBoxAddressStreet
            // 
            textBoxAddressStreet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressStreet.Location = new Point(384, 177);
            textBoxAddressStreet.Name = "textBoxAddressStreet";
            textBoxAddressStreet.Size = new Size(177, 31);
            textBoxAddressStreet.TabIndex = 5;
            // 
            // textBoxAddressCity
            // 
            textBoxAddressCity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressCity.Location = new Point(196, 177);
            textBoxAddressCity.Name = "textBoxAddressCity";
            textBoxAddressCity.Size = new Size(182, 31);
            textBoxAddressCity.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(573, 115);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(181, 34);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMiddleName.Location = new Point(384, 115);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(177, 34);
            textBoxMiddleName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(196, 115);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(182, 34);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxFacultyNumber
            // 
            textBoxFacultyNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFacultyNumber.Location = new Point(196, 59);
            textBoxFacultyNumber.Name = "textBoxFacultyNumber";
            textBoxFacultyNumber.Size = new Size(182, 34);
            textBoxFacultyNumber.TabIndex = 0;
            // 
            // FormStudentProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 576);
            Controls.Add(groupBoxStudentProfile);
            Controls.Add(groupBoxGrades);
            Controls.Add(groupBoxFees);
            Controls.Add(toolStrip1);
            Name = "FormStudentProfile";
            Text = "UniSystem";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBoxFees.ResumeLayout(false);
            groupBoxFees.PerformLayout();
            groupBoxGrades.ResumeLayout(false);
            groupBoxGrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxStudentProfile.ResumeLayout(false);
            groupBoxStudentProfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonProfile;
        private ToolStripButton toolStripButtonGrades;
        private ToolStripButton toolStripButtonFees;
        private GroupBox groupBoxFees;
        private TextBox textBoxUnpaidFees;
        private Label label1;
        private GroupBox groupBoxGrades;
        private TextBox textBoxAverageGrade;
        private Label label2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private GroupBox groupBoxStudentProfile;
        private TextBox textBoxFacultyNumber;
        private TextBox textBoxFirstName;
        private TextBox textBoxMiddleName;
        private TextBox textBoxLastName;
        private TextBox textBoxAddressCity;
        private TextBox textBoxAddressStreet;
        private TextBox textBoxMajor;
        private TextBox textBoxDegreeType;
        private TextBox textBoxStream;
        private TextBox textBoxGroup;
        private TextBox textBoxEnrollmentDate;
        private Button buttonLogOut;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label12;
    }
}