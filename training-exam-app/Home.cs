using System;
using System.Windows.Forms;
using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class Home : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            userTypeFilter();
        }

        private void userTypeFilter()
        {
            switch (CurrentUser.UserType)
            {
                case UserType.admin:
                    adminTransactions.Visible = true;
                    break;
                case UserType.examiner:
                    examinerTransactions.Visible = true;
                    break;
                default:
                    studentTransactions.Visible = true;
                    break;
            }
        }

        private void Home_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e) => Application.Exit();

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(QuestionsControl.InstanceQuestions))
            {
                container.Controls.Add(QuestionsControl.InstanceQuestions);
                QuestionsControl.InstanceQuestions.Dock = DockStyle.Fill;
            }
            QuestionsControl.InstanceQuestions.BringToFront();
            this.Text = @"Questions";
        }

        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestion();
            addQuestion.ShowDialog();
        }

        private void examModule_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ExamModule.InstanceQuestions))
            {
                container.Controls.Add(ExamModule.InstanceQuestions);
                ExamModule.InstanceQuestions.Dock = DockStyle.Fill;
            }
            ExamModule.InstanceQuestions.BringToFront();
            this.Text = @"Questions";
        }

        private void btnTrainingModule_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(TrainingModule.InstanceQuestions))
            {
                container.Controls.Add(TrainingModule.InstanceQuestions);
                TrainingModule.InstanceQuestions.Dock = DockStyle.Fill;
            }
            TrainingModule.InstanceQuestions.BringToFront();
            this.Text = @"Questions";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Report.InstanceQuestions))
            {
                container.Controls.Add(Report.InstanceQuestions);
                Report.InstanceQuestions.Dock = DockStyle.Fill;
            }
            Report.InstanceQuestions.BringToFront();
            this.Text = @"Questions";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(SettingsStudent.InstanceQuestions))
            {
                container.Controls.Add(SettingsStudent.InstanceQuestions);
                SettingsStudent.InstanceQuestions.Dock = DockStyle.Fill;
            }
            SettingsStudent.InstanceQuestions.BringToFront();
            this.Text = @"Questions";
        }
    }
}
