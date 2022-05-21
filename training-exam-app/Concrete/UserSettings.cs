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
    internal class UserSettings
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public int Sigma1 { get; set; }
        public int Sigma2 { get; set; }
        public int Sigma3 { get; set; }
        public int Sigma4 { get; set; }
        public int Sigma5 { get; set; }
        public int Sigma6 { get; set; }

        private void ExecuteState(int execute)
        {
            if (execute != -1)
                XtraMessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşleminiz Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            else
                XtraMessageBox.Show("İşleminiz sırasında bir hata oluştu lütfen tekrar deneyiniz.", "HATA!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public UserSettings GetUserSettings()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", SqlDbType.Int)

            };
            UserSettings userSettings = new UserSettings();
            parameters[0].Value = CurrentUser.Id;
            DataTable userSettingsData = new DataTable();
            userSettingsData = DatabaseTransactions.ExecuteDataTable("SELECT * From tblUserSettings Where UserId=@UserId", parameters);
            if (userSettingsData.Rows.Count > 0)
            {
                userSettings.Id = (int)userSettingsData.Rows[0]["Id"];
                userSettings.UserId = (int)userSettingsData.Rows[0]["UserId"];
                userSettings.Sigma1 = (int)userSettingsData.Rows[0]["Sigma1"];
                userSettings.Sigma2 = (int)userSettingsData.Rows[0]["Sigma2"];
                userSettings.Sigma3 = (int)userSettingsData.Rows[0]["Sigma3"];
                userSettings.Sigma4 = (int)userSettingsData.Rows[0]["Sigma4"];
                userSettings.Sigma5 = (int)userSettingsData.Rows[0]["Sigma5"];
                userSettings.Sigma6 = (int)userSettingsData.Rows[0]["Sigma6"];
            }
            return userSettings;
        }


        public bool UpdateUserSettings()
        {
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@Sigma1",SqlDbType.Int),
            new SqlParameter("@Sigma2",SqlDbType.Int),
            new SqlParameter("@Sigma3",SqlDbType.Int),
            new SqlParameter("@Sigma4",SqlDbType.Int),
            new SqlParameter("@Sigma5",SqlDbType.Int),
            new SqlParameter("@Sigma6",SqlDbType.Int),
            new SqlParameter("@Id",SqlDbType.Int)
            };
            parameters[0].Value = this.Sigma1;
            parameters[1].Value = this.Sigma2;
            parameters[2].Value = this.Sigma3;
            parameters[3].Value = this.Sigma4;
            parameters[4].Value = this.Sigma5;
            parameters[5].Value = this.Sigma6;
            parameters[6].Value = this.Id;

            int execute = DatabaseTransactions.ExecuteNonQuery("UPDATE tblUserSettings SET Sigma1=@Sigma1, Sigma2=@Sigma2, Sigma3=@Sigma3, Sigma4=@Sigma4, Sigma5=@Sigma5, Sigma6=@Sigma6 WHERE Id=@Id", parameters);
            ExecuteState(execute);
            if (execute == -1)
                return false;
            return true;
        }
    } 
}
