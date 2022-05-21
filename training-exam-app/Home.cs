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
            TrainingModule.IsSigma = true;
            if (!container.Controls.Contains(TrainingModule.InstanceExamModule))
            {
                container.Controls.Add(TrainingModule.InstanceExamModule);
                TrainingModule.InstanceExamModule.Dock = DockStyle.Fill;
            }
            TrainingModule.InstanceExamModule.BringToFront();
            this.Text = @"Questions";
        }

        private void btnTrainingModule_Click(object sender, EventArgs e)
        {
            TrainingModule.IsSigma = false;
            if (!container.Controls.Contains(TrainingModule.InstanceTrainingModule))
            {
                container.Controls.Add(TrainingModule.InstanceTrainingModule);
                TrainingModule.InstanceTrainingModule.Dock = DockStyle.Fill;
            }
            TrainingModule.InstanceTrainingModule.BringToFront();
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
            var settings = new Settings();
            settings.ShowDialog();
        }
    }
}
