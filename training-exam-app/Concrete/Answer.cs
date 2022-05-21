using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace training_exam_app.Concrete
{
    public class Answer
    {
        public int Id { get; set; } 
        public bool AnswerState { get; set; }
        public int QuestionId { get; set; }
        public string AnswerImagePath { get; set; } = "";
        public string AnswerContent { get; set; }

        public bool CreateAnswer()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AnswerState", SqlDbType.Int),
                new SqlParameter("@QuestionId",SqlDbType.Int),
                new SqlParameter("@AnswerImagePath", SqlDbType.Text),
                new SqlParameter("@AnswerContent", SqlDbType.Text)
            };
            parameters[0].Value = this.AnswerState;
            parameters[1].Value = this.QuestionId;
            parameters[2].Value = this.AnswerImagePath;
            parameters[3].Value = this.AnswerContent;
            int execute = DatabaseTransactions.ExecuteNonQuery("INSERT INTO tblAnswers(AnswerState,QuestionId,AnswerImagePath,AnswerContent) VALUES (@AnswerState, @QuestionId, @AnswerImagePath, @AnswerContent)", parameters);
            if(execute == -1)
            {
                return false;
            }

            return true;
        }

        public bool UpdateAnswer()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AnswerState", SqlDbType.Int),
                new SqlParameter("@QuestionId",SqlDbType.Int),
                new SqlParameter("@AnswerImagePath", SqlDbType.Text),
                new SqlParameter("@AnswerContent", SqlDbType.Text),
                new SqlParameter("@Id",SqlDbType.Int)
            };
            parameters[0].Value = this.AnswerState;
            parameters[1].Value = this.QuestionId;
            parameters[2].Value = this.AnswerImagePath;
            parameters[3].Value = this.AnswerContent;
            parameters[4].Value = this.Id;

            int execute = DatabaseTransactions.ExecuteNonQuery("UPDATE tblAnswers SET AnswerState=@AnswerState, QuestionId=@QuestionId, AnswerImagePath=@AnswerImagePath, AnswerContent=@AnswerContent WHERE Id=@Id", parameters);
            if (execute == -1)
            {
                return false;
            }

            return true;
        }

        public List<Answer> GetQuestionAnswers(int questionId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@QuestionId",SqlDbType.NVarChar),
            };
            parameters[0].Value = questionId;
            DataTable answersData = DatabaseTransactions.ExecuteDataTable(
                @"SELECT * FROM tblAnswers WHERE QuestionId=@QuestionId", parameters);
            var answer = new List<Answer>();
            for (int i = 0; i < answersData.Rows.Count; i++)
            {
                answer.Add(new Answer
                {
                    Id = (int)answersData.Rows[i]["Id"],
                    AnswerState = (bool)answersData.Rows[i]["AnswerState"],
                    QuestionId = (int)answersData.Rows[i]["QuestionId"],
                    AnswerImagePath =(string)answersData.Rows[i]["AnswerImagePath"],
                    AnswerContent=(string)answersData.Rows[i]["AnswerContent"]
                }); ;
            }
            return answer;
        }
    }
}
