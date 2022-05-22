using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_exam_app.Concrete
{
    internal class UserAnswers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public bool AnswerState { get; set; }
        public int UserId { get; set; } = CurrentUser.Id;

        private void ExecuteState(int execute)
        {
            if (execute == -1)
                XtraMessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CreateUserAnswers()
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@QuestionId",SqlDbType.NVarChar),
            new SqlParameter("@AnswerState",SqlDbType.Int),
            new SqlParameter("@UserId",SqlDbType.NVarChar),
            };
            parameters[0].Value = this.QuestionId;
            parameters[1].Value = this.AnswerState;
            parameters[2].Value = this.UserId;

            int execute = DatabaseTransactions.ExecuteNonQuery("INSERT INTO tblUserAnswers(QuestionId,AnswerState,UserId) VALUES(@QuestionId,@AnswerState,@UserId);", parameters);
            ExecuteState(execute);
        }

        public DataTable GetModuleReport()
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@UserId",SqlDbType.NVarChar),
            };
            parameters[0].Value = this.UserId;
            return DatabaseTransactions.ExecuteDataTable("SELECT tblQuestionModules.Id, tblQuestionModules.ModuleName, tblUserAnswers.AnswerState, COUNT(*) AS 'Total' FROM tblUserAnswers INNER JOIN tblQuestions ON tblUserAnswers.QuestionId=tblQuestions.Id INNER JOIN tblSubjects ON tblSubjects.Id=tblQuestions.QuestionSubjectId INNER JOIN tblQuestionModules ON tblSubjects.ModuleId=tblQuestionModules.Id WHERE tblUserAnswers.UserId=@UserId GROUP BY tblQuestionModules.Id, tblQuestionModules.ModuleName, tblUserAnswers.AnswerState",parameters);
        }
    }
}
