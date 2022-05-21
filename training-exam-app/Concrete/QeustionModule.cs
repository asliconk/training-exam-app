using System.Data;

namespace training_exam_app.Concrete
{
    public class QuestionModule
    {
        public int Id   { get; set; }
        public string ModuleName { get; set; }

        public DataTable GetQuestionModules()
        {
            return DatabaseTransactions.ExecuteDataTable("SELECT * FROM tblQuestionModules");
        }
    }
}
