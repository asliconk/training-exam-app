using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public UserSettings GetUserSettings()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", SqlDbType.Int)

            };
            UserSettings userSettings = new UserSettings();
            parameters[0].Value = CurrentUser.Id;
            DataTable userSettingsData = new DataTable();
            userSettingsData = DatabaseTransactions.ExecuteDataTable("SELECT * From tblUserSettings FROM Where UserId=@UserId", parameters);
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
    } 
}
