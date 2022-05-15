using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace training_exam_app.Concrete
{
    public class Question
    {
        public int Id { get; set; } 
        public QuestionStatus QuestionStatus { get; set; }
        public string QuestionImagePath { get; set; }
        public int QuestionModuleId  { get; set; }   
        public string QuestionContent { get; set; }

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
            return DatabaseTransactions.ExecuteDataTable("SELECT tblQuestions.*, tblQuestionModules.ModuleName, tblSubjects.SubjectName FROM tblQuestions INNER JOIN tblSubjects ON tblQuestions.QuestionSubjectId=tblSubjects.Id INNER JOIN tblQuestionModules ON tblQuestionModules.Id=tblSubjects.ModulId ORDER BY tblQuestions.Id DESC");
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
    }
}
