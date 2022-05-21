using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class AddQuestion : DevExpress.XtraEditors.XtraForm
    {
        private Question _question = new Question();
        private Subject subject = new Subject();

        public AddQuestion()
        {
            InitializeComponent();
        }

        public AddQuestion(int questionID)
        {
            InitializeComponent();
            this._question.Id = questionID;
        }

        private string uploadImage()
        {
            string uploadFileName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Jpg files (*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    uploadFileName = Path.GetRandomFileName() + ".jpg";
                    File.Copy(fileName, @"C:\\Users\\HP\\Documents\\GitHub\\training-exam-app\\training-exam-app\\Images\\" + uploadFileName);
                }
            }
            return uploadFileName;
        }

        private void txtAnswerOne_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _question.QuestionAnswers[0].AnswerImagePath = uploadImage();
        }

        private void AddQuestion_Load(object sender, System.EventArgs e)
        {
            var questionModule = new QuestionModule();
            cboxModule.DataSource = questionModule.GetQuestionModules();
            cboxModule.DisplayMember = "ModuleName";
            cboxModule.ValueMember = "Id";

            if (_question.Id != 0)
            {
                _question = _question.GetQuestion(this._question.Id);
                questionContent.Text = _question.QuestionContent;
                txtAnswerOne.Text = _question.QuestionAnswers[0].AnswerContent;
                txtAnswerTwo.Text = _question.QuestionAnswers[1].AnswerContent;
                txtAnswerThree.Text = _question.QuestionAnswers[2].AnswerContent;
                txtAnswerFour.Text = _question.QuestionAnswers[3].AnswerContent;
                rbtnAnswerStateOne.Checked = _question.QuestionAnswers[0].AnswerState;
                rbtnAnswerStateTwo.Checked = _question.QuestionAnswers[1].AnswerState;
                rbtnAnswerStateThree.Checked = _question.QuestionAnswers[2].AnswerState;
                rbtnAnswerStateFour.Checked = _question.QuestionAnswers[3].AnswerState;
                cboxModule.SelectedValue = _question.ModuleId;
                cboxModule.SelectedValue = _question.QuestionSubjectId;

                cboxSubject.DataSource = subject.GetSubjects(Convert.ToInt32(cboxModule.SelectedValue));
                cboxSubject.DisplayMember = "SubjectName";
                cboxSubject.ValueMember = "Id";
            }
            else
            {
                cboxSubject.DataSource = subject.GetSubjects(Convert.ToInt32(cboxModule.SelectedValue));
                cboxSubject.DisplayMember = "SubjectName";
                cboxSubject.ValueMember = "Id";

                cboxModule.SelectedIndex = 0;
                cboxSubject.SelectedIndex = 0;
                _question.QuestionAnswers = new List<Answer>();
                _question.QuestionAnswers.Add(new Answer());
                _question.QuestionAnswers.Add(new Answer());
                _question.QuestionAnswers.Add(new Answer());
                _question.QuestionAnswers.Add(new Answer());
            }
        }

        private void txtAnswerTwo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _question.QuestionAnswers[1].AnswerImagePath = uploadImage();
        }

        private void txtAnswerThree_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _question.QuestionAnswers[2].AnswerImagePath = uploadImage();
        }

        private void txtAnswerFour_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _question.QuestionAnswers[3].AnswerImagePath = uploadImage();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _question.QuestionContent = questionContent.Text;
            _question.QuestionStatus = QuestionStatus.waiting;
            _question.QuestionSubjectId = Convert.ToInt32(cboxSubject.SelectedValue);
            _question.QuestionAnswers[0].AnswerContent = txtAnswerOne.Text;
            _question.QuestionAnswers[1].AnswerContent = txtAnswerTwo.Text;
            _question.QuestionAnswers[2].AnswerContent = txtAnswerThree.Text;
            _question.QuestionAnswers[3].AnswerContent = txtAnswerFour.Text;
            _question.QuestionAnswers[0].AnswerState = rbtnAnswerStateOne.Checked;
            _question.QuestionAnswers[1].AnswerState = rbtnAnswerStateTwo.Checked;
            _question.QuestionAnswers[2].AnswerState = rbtnAnswerStateThree.Checked;
            _question.QuestionAnswers[3].AnswerState = rbtnAnswerStateFour.Checked;
            if (_question.Id == 0)
            {
                if (_question.CreateQuestion())
                    this.Close();
            }
            else
            {
                if (_question.UpdateQuestion())
                    this.Close();
            }
        }

        private void cboxModule_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboxModule.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                cboxSubject.DataSource = subject.GetSubjects(Convert.ToInt32(cboxModule.SelectedValue));
                cboxSubject.DisplayMember = "SubjectName";
                cboxSubject.ValueMember = "Id";
                cboxSubject.SelectedIndex = 0;
            }
        }
    }
}