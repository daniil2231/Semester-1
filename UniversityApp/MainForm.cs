using System;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class MainForm : Form
    {
        private University university = new University();

        public MainForm()
        {
            InitializeComponent();
            foreach (Grade grade in university.GetGradeOptions())
            {
                cbGrades.Items.Add(grade.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void tabUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabUniversity.SelectedIndex)
            {
                case 1:
                    ShowStudentResults();
                    break;
                case 2:
                    ShowStatistics();
                    break;
            }
        }

        private void ShowStatistics()
        {
            throw new NotImplementedException();
        }

        private void ShowStudentResults()
        {
            throw new NotImplementedException();
        }
    }
}
