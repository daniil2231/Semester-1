namespace UniversityApp
{
    partial class MainForm
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
            this.tabUniversity = new System.Windows.Forms.TabControl();
            this.tabAddGrades = new System.Windows.Forms.TabPage();
            this.cbGrades = new System.Windows.Forms.ComboBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabViewGrades = new System.Windows.Forms.TabPage();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderGrade = new System.Windows.Forms.ColumnHeader();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tbStatistics = new System.Windows.Forms.TextBox();
            this.tabUniversity.SuspendLayout();
            this.tabAddGrades.SuspendLayout();
            this.tabViewGrades.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUniversity
            // 
            this.tabUniversity.Controls.Add(this.tabAddGrades);
            this.tabUniversity.Controls.Add(this.tabViewGrades);
            this.tabUniversity.Controls.Add(this.tabStatistics);
            this.tabUniversity.Location = new System.Drawing.Point(42, 32);
            this.tabUniversity.Margin = new System.Windows.Forms.Padding(4);
            this.tabUniversity.Name = "tabUniversity";
            this.tabUniversity.SelectedIndex = 0;
            this.tabUniversity.Size = new System.Drawing.Size(754, 450);
            this.tabUniversity.TabIndex = 0;
            this.tabUniversity.SelectedIndexChanged += new System.EventHandler(this.tabUniversity_SelectedIndexChanged);
            // 
            // tabAddGrades
            // 
            this.tabAddGrades.Controls.Add(this.cbGrades);
            this.tabAddGrades.Controls.Add(this.tbStudentName);
            this.tabAddGrades.Controls.Add(this.btnAdd);
            this.tabAddGrades.Location = new System.Drawing.Point(4, 30);
            this.tabAddGrades.Margin = new System.Windows.Forms.Padding(4);
            this.tabAddGrades.Name = "tabAddGrades";
            this.tabAddGrades.Padding = new System.Windows.Forms.Padding(4);
            this.tabAddGrades.Size = new System.Drawing.Size(746, 416);
            this.tabAddGrades.TabIndex = 0;
            this.tabAddGrades.Text = "Adding grades";
            this.tabAddGrades.UseVisualStyleBackColor = true;
            // 
            // cbGrades
            // 
            this.cbGrades.FormattingEnabled = true;
            this.cbGrades.Location = new System.Drawing.Point(44, 97);
            this.cbGrades.Name = "cbGrades";
            this.cbGrades.Size = new System.Drawing.Size(263, 29);
            this.cbGrades.TabIndex = 3;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(44, 38);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.PlaceholderText = "Student name ...";
            this.tbStudentName.Size = new System.Drawing.Size(263, 29);
            this.tbStudentName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 154);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add grade";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabViewGrades
            // 
            this.tabViewGrades.Controls.Add(this.lvStudents);
            this.tabViewGrades.Location = new System.Drawing.Point(4, 30);
            this.tabViewGrades.Margin = new System.Windows.Forms.Padding(4);
            this.tabViewGrades.Name = "tabViewGrades";
            this.tabViewGrades.Padding = new System.Windows.Forms.Padding(4);
            this.tabViewGrades.Size = new System.Drawing.Size(746, 416);
            this.tabViewGrades.TabIndex = 1;
            this.tabViewGrades.Text = "View grades";
            this.tabViewGrades.UseVisualStyleBackColor = true;
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderGrade});
            this.lvStudents.HideSelection = false;
            this.lvStudents.Location = new System.Drawing.Point(18, 16);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(709, 383);
            this.lvStudents.TabIndex = 0;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 300;
            // 
            // columnHeaderGrade
            // 
            this.columnHeaderGrade.Text = "Grade";
            this.columnHeaderGrade.Width = 80;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.tbStatistics);
            this.tabStatistics.Location = new System.Drawing.Point(4, 30);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(746, 416);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // tbStatistics
            // 
            this.tbStatistics.Location = new System.Drawing.Point(16, 15);
            this.tbStatistics.Multiline = true;
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.Size = new System.Drawing.Size(715, 187);
            this.tbStatistics.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 525);
            this.Controls.Add(this.tabUniversity);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "University Administration";
            this.tabUniversity.ResumeLayout(false);
            this.tabAddGrades.ResumeLayout(false);
            this.tabAddGrades.PerformLayout();
            this.tabViewGrades.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUniversity;
        private System.Windows.Forms.TabPage tabAddGrades;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabViewGrades;
        private System.Windows.Forms.ComboBox cbGrades;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderGrade;
        private System.Windows.Forms.TextBox tbStatistics;
    }
}
