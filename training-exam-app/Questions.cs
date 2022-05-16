using System;
using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class QuestionsControl : DevExpress.XtraEditors.XtraUserControl
    {
        private Question question = new Question();
        private static QuestionsControl _instanceProductList;
        public static QuestionsControl InstanceQuestions
        {
            get
            {
                if (_instanceProductList == null)
                    _instanceProductList = new QuestionsControl();
                return _instanceProductList;
            }
        }

        public QuestionsControl()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            grdQuestions.DataSource = question.GetQuestions();
        }

        private void QuestionsControl_Load(object sender, EventArgs e)
        {
            if(CurrentUser.UserType == UserType.examiner)
            {
                questionApprove.Visible = false;
                questionDontApprove.Visible = false;
            }
            this.LoadData();
        }

        private void questionApprove_Click(object sender, EventArgs e)
        {
            question.UpdateQuestionStatus(Convert.ToInt32(gvQuestions.GetRowCellValue(gvQuestions.FocusedRowHandle, "Id")), QuestionStatus.approved);
            this.LoadData();
        }

        private void questionDontApprove_Click(object sender, EventArgs e)
        {
            question.UpdateQuestionStatus(Convert.ToInt32(gvQuestions.GetRowCellValue(gvQuestions.FocusedRowHandle, "Id")), QuestionStatus.dontApproved);
            this.LoadData();
        }

        private void updateQuestion_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestion(Convert.ToInt32(gvQuestions.GetRowCellValue(gvQuestions.FocusedRowHandle, "Id")));
            addQuestion.ShowDialog();
        }

        private void deleteQuestion_Click(object sender, EventArgs e)
        {
            this.question.DeleteQuestion(Convert.ToInt32(gvQuestions.GetRowCellValue(gvQuestions.FocusedRowHandle, "Id")));
            this.LoadData();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
