using System.Data;
using System.Data.SqlClient;

namespace training_exam_app.Concrete
{
    public class Subject
    {
        public int Id { get; set; } 
        public string SubjectName { get; set; }
        public int ModulId { get; set; }

        public DataTable GetSubjects(int moduleId)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@ModuleId",SqlDbType.Int),
            };
            parameters[0].Value = moduleId;

            return DatabaseTransactions.ExecuteDataTable(@"SELECT * FROM tblSubjects WHERE ModuleId=@moduleId", parameters);
        }
    }
}
