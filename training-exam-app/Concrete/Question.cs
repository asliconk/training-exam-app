using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace training_exam_app.Concrete
{
    public class Question
    {
        public int Id { get; set; } = 0;
        public QuestionStatus QuestionStatus { get; set; }
        public string QuestionImagePath { get; set; } = string.Empty;
        public int QuestionSubjectId { get; set; }
        public string QuestionContent { get; set; }
        public List<Answer> QuestionAnswers { get; set; }
        public int ModuleId { get; set; }

        private void ExecuteState(int execute)
        {
            if (execute != -1)
                XtraMessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşleminiz Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                XtraMessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataTable GetQuestions()
        {
            return DatabaseTransactions.ExecuteDataTable("SELECT tblQuestions.*, tblQuestionModules.ModuleName, tblSubjects.SubjectName FROM tblQuestions INNER JOIN tblSubjects ON tblQuestions.QuestionSubjectId=tblSubjects.Id INNER JOIN tblQuestionModules ON tblQuestionModules.Id=tblSubjects.ModuleId ORDER BY tblQuestions.Id DESC");
        }

        public List<Question> GetRandomTenQuestion()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@QuestionStatus", SqlDbType.Int)
            };
            parameters[0].Value = (int)QuestionStatus.approved;
            DataTable questionData = new DataTable();
            questionData= DatabaseTransactions.ExecuteDataTable("SELECT TOP 10 * FROM tblQuestions WHERE QuestionStatus=@QuestionStatus ORDER BY NEWID();", parameters);
            List<Question> questionList = new List<Question>();
            Answer answer = new Answer();
            for (int i = 0; i < questionData.Rows.Count; i++)
            {

                questionList.Add(new Question {
                    Id = (int)questionData.Rows[i]["Id"],
                    QuestionContent = (string)questionData.Rows[i]["QuestionContent"],
                    QuestionImagePath = (string)questionData.Rows[i]["QuestionImagePath"],
                    QuestionSubjectId = (int)questionData.Rows[i]["QuestionSubjectId"],
                    QuestionStatus = (QuestionStatus)questionData.Rows[i]["QuestionStatus"],
                    QuestionAnswers = answer.GetQuestionAnswers((int)questionData.Rows[i]["Id"])
                });
            }
            return questionList;
        }

        public void UpdateQuestionStatus(int Id, QuestionStatus status)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.Int),
                new SqlParameter("@QuestionStatus", SqlDbType.NVarChar)
            };
            parameters[0].Value = Id;
            parameters[1].Value = status;
            int execute = DatabaseTransactions.ExecuteNonQuery("UPDATE tblQuestions SET QuestionStatus=@QuestionStatus where Id=@Id", parameters);
            ExecuteState(execute);
        }

        public bool CreateQuestion()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@QuestionStatus", SqlDbType.Int),
                new SqlParameter("@QuestionImagePath", SqlDbType.NVarChar),
                new SqlParameter("@QuestionSubjectId", SqlDbType.Int),
                new SqlParameter("@QuestionContent", SqlDbType.NText),

            };
            parameters[0].Value = (int)this.QuestionStatus;
            parameters[1].Value = this.QuestionImagePath;
            parameters[2].Value = this.QuestionSubjectId;
            parameters[3].Value = this.QuestionContent;
            var questionId = DatabaseTransactions.ExecuteScalar("INSERT INTO tblQuestions(QuestionStatus,QuestionImagePath,QuestionContent,QuestionSubjectId) VALUES (@QuestionStatus, @QuestionImagePath, @QuestionContent, @QuestionSubjectId); SELECT @@IDENTITY;", parameters);
            if (questionId == null)
            {
                ExecuteState(-1);
                return false;
            }

            foreach (var answer in this.QuestionAnswers)
            {
                answer.QuestionId = Convert.ToInt32(questionId);
                if (!answer.CreateAnswer())
                    ExecuteState(-1);
            }
            ExecuteState(1);
            return true;
        }

        public bool UpdateQuestion()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter ("@Id", SqlDbType.Int),
                new SqlParameter("@QuestionStatus", SqlDbType.Int),
                new SqlParameter("@QuestionImagePath", SqlDbType.NVarChar),
                new SqlParameter("@QuestionSubjectId", SqlDbType.Int),
                new SqlParameter("@QuestionContent", SqlDbType.NText),
            };
            if ((int)this.QuestionStatus == 0 || string.IsNullOrEmpty(this.QuestionContent)  || this.QuestionSubjectId == 0 || this.Id == 0)
            {
                MessageBox.Show("değerlerden biri boş");
                return false;
            }
            parameters[0].Value = this.Id;
            parameters[1].Value = (int)this.QuestionStatus;
            parameters[2].Value = this.QuestionImagePath;
            parameters[3].Value = this.QuestionSubjectId;
            parameters[4].Value = this.QuestionContent;

            var execute = DatabaseTransactions.ExecuteNonQuery("UPDATE tblQuestions SET QuestionStatus=@QuestionStatus, QuestionImagePath=@QuestionImagePath,QuestionSubjectId=@QuestionSubjectId, QuestionContent=@QuestionContent where Id=@Id;", parameters);
            if (execute == -1)
            {
                ExecuteState(execute);
                return false;
            }

            foreach (var answer in this.QuestionAnswers)
            {
                answer.QuestionId = Convert.ToInt32(this.Id);
                if (!answer.UpdateAnswer())
                    ExecuteState(-1);
            }
            ExecuteState(1);
            return true;
        }

        public Question GetQuestion(int questionId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@QuestionId",SqlDbType.NVarChar),
            };
            parameters[0].Value = questionId;
            DataTable userData = DatabaseTransactions.ExecuteDataTable(
                @"SELECT tblQuestions.*, tblQuestionModules.Id AS 'ModuleId' FROM tblQuestions INNER JOIN tblSubjects ON tblSubjects.Id=tblQuestions.QuestionSubjectId INNER JOIN tblQuestionModules ON tblQuestionModules.Id=tblSubjects.ModuleId WHERE tblQuestions.Id=@QuestionId", parameters);
            var question = new Question();
            if (userData.Rows.Count > 0)
            {
                question.Id = questionId;
                question.QuestionStatus = (QuestionStatus)userData.Rows[0]["QuestionStatus"];
                question.QuestionImagePath = (string)userData.Rows[0]["QuestionImagePath"];
                question.QuestionContent = (string)userData.Rows[0]["QuestionContent"];
                question.QuestionSubjectId = (int)userData.Rows[0]["QuestionSubjectId"];
                question.ModuleId = (int)userData.Rows[0]["ModuleId"];
                var answer = new Answer();
                question.QuestionAnswers = answer.GetQuestionAnswers(questionId);
            }
            return question;
        }

        public void DeleteQuestion(int questionId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@QuestionId",SqlDbType.NVarChar),
            };
            parameters[0].Value = questionId;
            int execute = DatabaseTransactions.ExecuteNonQuery(
                @"DELETE FROM tblQuestions WHERE Id=@QuestionId", parameters);
            ExecuteState(execute);
        }

        public List<Question> GetRandomTenSigmaQuestion()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@QuestionStatus", SqlDbType.Int),
                new SqlParameter("@UserId",SqlDbType.Int)
            };
            parameters[0].Value = (int)QuestionStatus.approved;
            parameters[1].Value = CurrentUser.Id;
            DataTable questionData = new DataTable();
            questionData = DatabaseTransactions.ExecuteDataTable("SELECT TOP 10 * FROM tblQuestions WHERE Id not in (SELECT QuestionId FROM tblSigma WHERE GETDATE() < SigmaDate AND UserId = @UserId) ORDER BY NEWID();", parameters);
            List<Question> questionList = new List<Question>();
            Answer answer = new Answer();
            for (int i = 0; i < questionData.Rows.Count; i++)
            {

                questionList.Add(new Question
                {
                    Id = (int)questionData.Rows[i]["Id"],
                    QuestionContent = (string)questionData.Rows[i]["QuestionContent"],
                    QuestionImagePath = (string)questionData.Rows[i]["QuestionImagePath"],
                    QuestionSubjectId = (int)questionData.Rows[i]["QuestionSubjectId"],
                    QuestionStatus = (QuestionStatus)questionData.Rows[i]["QuestionStatus"],
                    QuestionAnswers = answer.GetQuestionAnswers((int)questionData.Rows[i]["Id"])
                });
            }
            return questionList;
        }
    }
}
