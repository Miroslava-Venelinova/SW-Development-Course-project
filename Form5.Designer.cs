namespace UniSystem
{
    partial class FormTeacherProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherProfile));
            toolStrip1 = new ToolStrip();
            toolStripButtonProfile = new ToolStripButton();
            toolStripButtonGrading = new ToolStripButton();
            toolStripButtonSearches = new ToolStripButton();
            groupBoxProfile = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonLogOut = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBoxSearches = new GroupBox();
            label4 = new Label();
            buttonSearch = new Button();
            textBoxInput = new TextBox();
            dataGridView2 = new DataGridView();
            comboBoxOptions = new ComboBox();
            groupBoxGrading = new GroupBox();
            textBoxGradeValue = new TextBox();
            textBoxSubject = new TextBox();
            textBoxFacultyNumber = new TextBox();
            textBoxEntryDate = new TextBox();
            buttonAddGrade = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            toolStrip1.SuspendLayout();
            groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxSearches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBoxGrading.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonProfile, toolStripButtonGrading, toolStripButtonSearches });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1108, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonProfile
            // 
            toolStripButtonProfile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonProfile.ForeColor = Color.Teal;
            toolStripButtonProfile.Image = (Image)resources.GetObject("toolStripButtonProfile.Image");
            toolStripButtonProfile.ImageTransparentColor = Color.Magenta;
            toolStripButtonProfile.Name = "toolStripButtonProfile";
            toolStripButtonProfile.Size = new Size(82, 29);
            toolStripButtonProfile.Text = "Профил";
            toolStripButtonProfile.Click += toolStripButtonProfile_Click;
            // 
            // toolStripButtonGrading
            // 
            toolStripButtonGrading.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonGrading.ForeColor = Color.Teal;
            toolStripButtonGrading.Image = (Image)resources.GetObject("toolStripButtonGrading.Image");
            toolStripButtonGrading.ImageTransparentColor = Color.Magenta;
            toolStripButtonGrading.Name = "toolStripButtonGrading";
            toolStripButtonGrading.Size = new Size(107, 29);
            toolStripButtonGrading.Text = "Оценяване";
            toolStripButtonGrading.Click += toolStripButtonGrading_Click;
            // 
            // toolStripButtonSearches
            // 
            toolStripButtonSearches.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearches.ForeColor = Color.Teal;
            toolStripButtonSearches.Image = (Image)resources.GetObject("toolStripButtonSearches.Image");
            toolStripButtonSearches.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearches.Name = "toolStripButtonSearches";
            toolStripButtonSearches.Size = new Size(86, 29);
            toolStripButtonSearches.Text = "Справки";
            toolStripButtonSearches.Click += toolStripButtonSearches_Click;
            // 
            // groupBoxProfile
            // 
            groupBoxProfile.Controls.Add(label3);
            groupBoxProfile.Controls.Add(label2);
            groupBoxProfile.Controls.Add(label1);
            groupBoxProfile.Controls.Add(buttonLogOut);
            groupBoxProfile.Controls.Add(dataGridView1);
            groupBoxProfile.Controls.Add(textBox3);
            groupBoxProfile.Controls.Add(textBox2);
            groupBoxProfile.Controls.Add(textBox1);
            groupBoxProfile.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxProfile.ForeColor = Color.Teal;
            groupBoxProfile.Location = new Point(42, 70);
            groupBoxProfile.Name = "groupBoxProfile";
            groupBoxProfile.Size = new Size(982, 488);
            groupBoxProfile.TabIndex = 1;
            groupBoxProfile.TabStop = false;
            groupBoxProfile.Text = "Инфомация за учителя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 208);
            label3.Name = "label3";
            label3.Size = new Size(119, 26);
            label3.TabIndex = 7;
            label3.Text = "Предмети";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 139);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 6;
            label2.Text = "Имена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 80);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 5;
            label1.Text = "уч. №";
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Teal;
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(836, 30);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(112, 34);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "Изход";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(849, 190);
            dataGridView1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(432, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 32);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 32);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(211, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 34);
            textBox1.TabIndex = 0;
            // 
            // groupBoxSearches
            // 
            groupBoxSearches.Controls.Add(label4);
            groupBoxSearches.Controls.Add(buttonSearch);
            groupBoxSearches.Controls.Add(textBoxInput);
            groupBoxSearches.Controls.Add(dataGridView2);
            groupBoxSearches.Controls.Add(comboBoxOptions);
            groupBoxSearches.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxSearches.ForeColor = Color.Teal;
            groupBoxSearches.Location = new Point(42, 70);
            groupBoxSearches.Name = "groupBoxSearches";
            groupBoxSearches.Size = new Size(982, 488);
            groupBoxSearches.TabIndex = 8;
            groupBoxSearches.TabStop = false;
            groupBoxSearches.Text = "Справки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(580, 94);
            label4.Name = "label4";
            label4.Size = new Size(256, 26);
            label4.TabIndex = 4;
            label4.Text = "Изберете вида справка:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Teal;
            buttonSearch.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(705, 283);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 34);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Търси";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(579, 214);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(369, 34);
            textBoxInput.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(521, 336);
            dataGridView2.TabIndex = 1;
            // 
            // comboBoxOptions
            // 
            comboBoxOptions.FormattingEnabled = true;
            comboBoxOptions.Items.AddRange(new object[] { "Студент по имена", "Студент по фак. номер", "Студент по изучаван предмет", "Студент по ср. успех", "Списък с всички оценки на студент", "Среден успех на студентите", "Брой оценки от даден период", "Последни 10 записани студенти", "Студенти с над 1000 лв. неплатени такси" });
            comboBoxOptions.Location = new Point(580, 151);
            comboBoxOptions.Name = "comboBoxOptions";
            comboBoxOptions.Size = new Size(369, 36);
            comboBoxOptions.TabIndex = 0;
            // 
            // groupBoxGrading
            // 
            groupBoxGrading.Controls.Add(textBoxGradeValue);
            groupBoxGrading.Controls.Add(textBoxSubject);
            groupBoxGrading.Controls.Add(textBoxFacultyNumber);
            groupBoxGrading.Controls.Add(textBoxEntryDate);
            groupBoxGrading.Controls.Add(buttonAddGrade);
            groupBoxGrading.Controls.Add(label8);
            groupBoxGrading.Controls.Add(label7);
            groupBoxGrading.Controls.Add(label6);
            groupBoxGrading.Controls.Add(label5);
            groupBoxGrading.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxGrading.ForeColor = Color.Teal;
            groupBoxGrading.Location = new Point(42, 70);
            groupBoxGrading.Name = "groupBoxGrading";
            groupBoxGrading.Size = new Size(982, 488);
            groupBoxGrading.TabIndex = 5;
            groupBoxGrading.TabStop = false;
            groupBoxGrading.Text = "Оценяване";
            // 
            // textBoxGradeValue
            // 
            textBoxGradeValue.Location = new Point(214, 268);
            textBoxGradeValue.Name = "textBoxGradeValue";
            textBoxGradeValue.Size = new Size(236, 32);
            textBoxGradeValue.TabIndex = 8;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(214, 211);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(236, 32);
            textBoxSubject.TabIndex = 7;
            // 
            // textBoxFacultyNumber
            // 
            textBoxFacultyNumber.Location = new Point(214, 151);
            textBoxFacultyNumber.Name = "textBoxFacultyNumber";
            textBoxFacultyNumber.Size = new Size(236, 32);
            textBoxFacultyNumber.TabIndex = 6;
            // 
            // textBoxEntryDate
            // 
            textBoxEntryDate.Location = new Point(214, 91);
            textBoxEntryDate.Name = "textBoxEntryDate";
            textBoxEntryDate.Size = new Size(236, 32);
            textBoxEntryDate.TabIndex = 5;
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.BackColor = Color.Teal;
            buttonAddGrade.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddGrade.ForeColor = Color.White;
            buttonAddGrade.Location = new Point(227, 354);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new Size(112, 34);
            buttonAddGrade.TabIndex = 4;
            buttonAddGrade.Text = "Въведи";
            buttonAddGrade.UseVisualStyleBackColor = false;
            buttonAddGrade.Click += buttonAddGrade_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 271);
            label8.Name = "label8";
            label8.Size = new Size(88, 26);
            label8.TabIndex = 3;
            label8.Text = "Оценка:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(99, 214);
            label7.Name = "label7";
            label7.Size = new Size(107, 26);
            label7.TabIndex = 2;
            label7.Text = "Предмет:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 151);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 1;
            label6.Text = "фак. №:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 94);
            label5.Name = "label5";
            label5.Size = new Size(68, 26);
            label5.TabIndex = 0;
            label5.Text = "Дата:";
            // 
            // FormTeacherProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 615);
            Controls.Add(groupBoxGrading);
            Controls.Add(groupBoxSearches);
            Controls.Add(groupBoxProfile);
            Controls.Add(toolStrip1);
            Name = "FormTeacherProfile";
            Text = "UniSystem";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBoxProfile.ResumeLayout(false);
            groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxSearches.ResumeLayout(false);
            groupBoxSearches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBoxGrading.ResumeLayout(false);
            groupBoxGrading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonProfile;
        private ToolStripButton toolStripButtonGrading;
        private ToolStripButton toolStripButtonSearches;
        private GroupBox groupBoxProfile;
        private Button buttonLogOut;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxSearches;
        private Button buttonSearch;
        private TextBox textBoxInput;
        private DataGridView dataGridView2;
        private ComboBox comboBoxOptions;
        private Label label4;
        private GroupBox groupBoxGrading;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button buttonAddGrade;
        private TextBox textBoxGradeValue;
        private TextBox textBoxSubject;
        private TextBox textBoxFacultyNumber;
        private TextBox textBoxEntryDate;
    }
}