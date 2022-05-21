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
    }
}
