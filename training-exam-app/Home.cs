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
    }
}
