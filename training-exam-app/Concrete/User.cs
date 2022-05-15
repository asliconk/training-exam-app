using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        private void ExecuteState(int execute)
        {
            if (execute != -1)
                XtraMessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşleminiz Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                XtraMessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Login(string EmailAddress, string Password)
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
            new SqlParameter("@Password",SqlDbType.NVarChar)
            };
            parameters[0].Value = EmailAddress;
            parameters[1].Value = Password;
            DataTable userData = DatabaseTransactions.ExecuteDataTable(
                @"SELECT * FROM tblUsers WHERE EmailAddress=@EmailAddress AND Password=@Password", parameters);
            if (userData.Rows.Count > 0)
            {
                CurrentUser.FirstName = (string)userData.Rows[0]["FirstName"];
                CurrentUser.LastName = (string)userData.Rows[0]["LastName"];
                CurrentUser.UserType = (UserType)userData.Rows[0]["UserType"];
                CurrentUser.EmailAddress = (string)userData.Rows[0]["EmailAddress"];
                CurrentUser.Id = (int)userData.Rows[0]["Id"];
                return true;
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı!", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
