namespace Final
{
    partial class StudentEditForm
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
            tabControl1 = new TabControl();
            tabPesonal = new TabPage();
            dtpBirthDate = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabCourses = new TabPage();
            btnAssignCourse = new Button();
            cmbYears = new ComboBox();
            lstCourses = new ListBox();
            label5 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            tabControl1.SuspendLayout();
            tabPesonal.SuspendLayout();
            tabCourses.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPesonal);
            tabControl1.Controls.Add(tabCourses);
            tabControl1.Location = new Point(81, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(447, 209);
            tabControl1.TabIndex = 0;
            // 
            // tabPesonal
            // 
            tabPesonal.Controls.Add(dtpBirthDate);
            tabPesonal.Controls.Add(txtLastName);
            tabPesonal.Controls.Add(txtFirstName);
            tabPesonal.Controls.Add(label3);
            tabPesonal.Controls.Add(label2);
            tabPesonal.Controls.Add(label1);
            tabPesonal.Location = new Point(4, 29);
            tabPesonal.Name = "tabPesonal";
            tabPesonal.Padding = new Padding(3);
            tabPesonal.Size = new Size(439, 176);
            tabPesonal.TabIndex = 0;
            tabPesonal.Text = "Person";
            tabPesonal.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(118, 118);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(119, 59);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(286, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(119, 13);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(286, 27);
            txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 114);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "BirthDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 62);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // tabCourses
            // 
            tabCourses.Controls.Add(btnAssignCourse);
            tabCourses.Controls.Add(cmbYears);
            tabCourses.Controls.Add(lstCourses);
            tabCourses.Controls.Add(label5);
            tabCourses.Controls.Add(label4);
            tabCourses.Location = new Point(4, 29);
            tabCourses.Name = "tabCourses";
            tabCourses.Padding = new Padding(3);
            tabCourses.Size = new Size(439, 176);
            tabCourses.TabIndex = 1;
            tabCourses.Text = "Courses";
            tabCourses.UseVisualStyleBackColor = true;
            // 
            // btnAssignCourse
            // 
            btnAssignCourse.Location = new Point(197, 94);
            btnAssignCourse.Name = "btnAssignCourse";
            btnAssignCourse.Size = new Size(94, 29);
            btnAssignCourse.TabIndex = 4;
            btnAssignCourse.Text = "Assign";
            btnAssignCourse.UseVisualStyleBackColor = true;
            btnAssignCourse.Click += btnAssignCourse_Click;
            // 
            // cmbYears
            // 
            cmbYears.FormattingEnabled = true;
            cmbYears.Location = new Point(193, 40);
            cmbYears.Name = "cmbYears";
            cmbYears.Size = new Size(151, 28);
            cmbYears.TabIndex = 3;
            // 
            // lstCourses
            // 
            lstCourses.FormattingEnabled = true;
            lstCourses.Location = new Point(19, 38);
            lstCourses.Name = "lstCourses";
            lstCourses.Size = new Size(150, 104);
            lstCourses.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 15);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 1;
            label5.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 15);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 0;
            label4.Text = "Classes";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tabControl1);
            Name = "StudentEditForm";
            Text = "StudentEditForm";
            tabControl1.ResumeLayout(false);
            tabPesonal.ResumeLayout(false);
            tabPesonal.PerformLayout();
            tabCourses.ResumeLayout(false);
            tabCourses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPesonal;
        private DateTimePicker dtpBirthDate;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabCourses;
        private Label label4;
        private Button btnAssignCourse;
        private ComboBox cmbYears;
        private ListBox lstCourses;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
    }
}