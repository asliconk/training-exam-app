 using System;
using System.Collections.Generic;
using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class TrainingModule : DevExpress.XtraEditors.XtraUserControl
    {
        private static TrainingModule _instanceTrainingModule;
        private static TrainingModule _instanceExamnModule;
        public static bool IsSigma = false;
        private int questionOfNumber = 0;
        private Question currentQuestion = new Question();
        private List<Question> questions= new List<Question>();
        private int emptyOfNumber = 0;
        private int successOfNumber = 0;
        private int failOfNumber = 0;

        public static TrainingModule InstanceTrainingModule
        {
            get
            {
                if (_instanceTrainingModule == null)
                    _instanceTrainingModule = new TrainingModule();
                return _instanceTrainingModule;
            }
        }

        public static TrainingModule InstanceExamModule
        {
            get
            {
                if (_instanceExamnModule == null)
                    _instanceExamnModule = new TrainingModule();
                return _instanceExamnModule;
            }
        }
        public TrainingModule()
        {
            InitializeComponent();
        }

        private void TrainingModule_Load(object sender, EventArgs e)
        {
            grpAnswer.Visible = false;
            grpQuestion.Visible = false;
            btnStart.Text = IsSigma ? "Start Exam" : "Start Training";
        }

        private void showQuestion (Question question)
        {
            questionContent.Text = question.QuestionContent;
            lblAnswerStateOne.Text = question.QuestionAnswers[0].AnswerContent;
            lblAnswerStateTwo.Text = question.QuestionAnswers[1].AnswerContent;
            lblAnswerStateThree.Text = question.QuestionAnswers[2].AnswerContent;
            lblAnswerStateFour.Text = question.QuestionAnswers[3].AnswerContent;
            rbtnAnswerStateOne.Checked = false;
            rbtnAnswerStateTwo.Checked = false;
            rbtnAnswerStateThree.Checked = false;
            rbtnAnswerStateFour.Checked = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            questionOfNumber = 0;
            lblQuestionNumber.Text = (questionOfNumber + 1).ToString();
            if(IsSigma)
                questions = currentQuestion.GetRandomTenSigmaQuestion();
            else
                questions = currentQuestion.GetRandomTenQuestion();
            currentQuestion = questions[questionOfNumber];
            showQuestion(currentQuestion);
            grpQuestion.Visible = true;
            grpAnswer.Visible = false;
        }

        private void endQuestion()
        {
            lblEmptyOfNumber.Text = this.emptyOfNumber.ToString();
            lblSuccessOfNumber.Text = this.successOfNumber.ToString();
            lblFailOfNumber.Text = this.failOfNumber.ToString();
            grpQuestion.Visible = false;
            grpAnswer.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserAnswers userAnswers = new UserAnswers();
            userAnswers.QuestionId = currentQuestion.Id;
            userAnswers.AnswerState = this.answerState();
            userAnswers.CreateUserAnswers();
            ++questionOfNumber;
            if(questionOfNumber < questions.Count)
            {
                lblQuestionNumber.Text = (questionOfNumber + 1).ToString();
                currentQuestion = questions[questionOfNumber];
                showQuestion(currentQuestion);
            }
            else
            {
                endQuestion();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++questionOfNumber;
            ++emptyOfNumber;
            if (questionOfNumber < questions.Count)
            {
                lblQuestionNumber.Text = (questionOfNumber + 1).ToString();
                currentQuestion = questions[questionOfNumber];
                showQuestion(currentQuestion);
            }
            else
            {
                endQuestion();
            }
        }

        private bool answerState()
        {
            if(rbtnAnswerStateOne.Checked != currentQuestion.QuestionAnswers[0].AnswerState)
            {
                ++failOfNumber;
                return false;
            }

            if (rbtnAnswerStateTwo.Checked != currentQuestion.QuestionAnswers[1].AnswerState)
            {
                ++failOfNumber;
                return false;
            }

            if (rbtnAnswerStateThree.Checked != currentQuestion.QuestionAnswers[2].AnswerState)
            {
                ++failOfNumber;
                return false;
            }

            if (rbtnAnswerStateFour.Checked != currentQuestion.QuestionAnswers[3].AnswerState)
            {
                ++failOfNumber;
                return false;
            }

            ++successOfNumber;
            return true;
        }
    }
}
