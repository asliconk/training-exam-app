using DevExpress.XtraEditors;
using System;
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
        
        public bool SignUp()
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@FirstName",SqlDbType.NVarChar),
            new SqlParameter("@LastName",SqlDbType.NVarChar),
            new SqlParameter("@UserType",SqlDbType.Int),
            new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
            new SqlParameter("@Password",SqlDbType.NVarChar)
            };
            parameters[0].Value = this.FirstName;
            parameters[1].Value = this.LastName;
            parameters[2].Value = this.UserType;
            parameters[3].Value = this.EmailAddress;
            parameters[4].Value = this.Password;

            int execute = DatabaseTransactions.ExecuteNonQuery("INSERT INTO tblUsers(FirstName,LastName,UserType,EmailAddress,Password) VALUES(@FirstName,@LastName,@UserType,@EmailAddress,@Password);", parameters);
            ExecuteState(execute);
            if (execute == -1)
                return false;
            return true;
        }

        public bool ForgotPassword()
        {
            if (!this.IsUserEmailAddress())
                return false;

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@RecoveryKey",SqlDbType.NVarChar),
                new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
            };

            Random rastgele = new Random();
            parameters[0].Value = rastgele.Next(100, 999);
            parameters[1].Value = this.EmailAddress;

            int execute = DatabaseTransactions.ExecuteNonQuery("UPDATE tblUsers SET RecoveryKey=@RecoveryKey WHERE EmailAddress=@EmailAddress", parameters);
            ExecuteState(execute);
            if (execute == -1)
                return false;
            return true;
        }

        public bool IsUserEmailAddress()
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
            };
            parameters[0].Value = this.EmailAddress;

            DataTable userData = DatabaseTransactions.ExecuteDataTable(
                @"SELECT * FROM tblUsers WHERE EmailAddress=@EmailAddress", parameters);
            if (userData.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                XtraMessageBox.Show("Email addresi sisteme kayıt değil", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool IsRecoveryPin()
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
                new SqlParameter("@RecoveryKey",SqlDbType.NVarChar),
            };
            parameters[0].Value = this.EmailAddress;
            parameters[1].Value = this.RecoverKey;

            DataTable userData = DatabaseTransactions.ExecuteDataTable(
                @"SELECT * FROM tblUsers WHERE EmailAddress=@EmailAddress AND RecoveryKey=@RecoveryKey", parameters);
            if (userData.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                XtraMessageBox.Show("Pin kodu yanlış!", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ResetPassword()
        {
            if (!this.IsRecoveryPin())
                return false;

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@RecoveryKey",SqlDbType.NVarChar),
                new SqlParameter("@EmailAddress",SqlDbType.NVarChar),
                new SqlParameter("@Password",SqlDbType.NVarChar),
                new SqlParameter("@NewRecoveryKey",SqlDbType.NVarChar),
            };

            Random rastgele = new Random();
            parameters[0].Value = this.RecoverKey;
            parameters[1].Value = this.EmailAddress;
            parameters[2].Value = this.Password;
            parameters[3].Value = "";

            int execute = DatabaseTransactions.ExecuteNonQuery("UPDATE tblUsers SET RecoveryKey=@NewRecoveryKey, Password=@Password WHERE EmailAddress=@EmailAddress AND RecoveryKey=@RecoveryKey", parameters);
            ExecuteState(execute);
            if (execute == -1)
                return false;
            return true;
        }
    }
}
