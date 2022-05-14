using System.Data;
using System.Data.SqlClient;

namespace training_exam_app.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string RecoverKey { get; set; }

        public User Login(string EmailAddress, string Password)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
            new SqlParameter("Password",SqlDbType.NVarChar)
            };
            parameters[0].Value = DatabaseTransactions.Rearrange(EmailAddress);;
            parameters[1].Value = DatabaseTransactions.Rearrange(Password);
            DataTable userData = DatabaseTransactions.ExecuteDataTable(
                @"SELECT * FROM tblUser WHERE EmailAddress=@EmailAddress AND Password=@Password", parameters);
            if (userData.Rows.Count > 0)
            {
                User user = new User();
                user.FirstName = (string)userData.Rows[0]["FirstName"];
                user.LastName = (string)userData.Rows[0]["LastName"];
                user.UserType = (UserType)userData.Rows[0]["UserType"];
                user.EmailAddress = (string)userData.Rows[0]["EmailAddress"];
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
