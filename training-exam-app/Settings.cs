using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        private UserSettings _settings = new UserSettings();
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _settings.Sigma1 = Convert.ToInt32(textBoxSigma1.Text);
            _settings.Sigma2 = Convert.ToInt32(textBoxSigma2.Text);
            _settings.Sigma3 = Convert.ToInt32(textBoxSigma3.Text);
            _settings.Sigma4 = Convert.ToInt32(textBoxSigma4.Text);
            _settings.Sigma5 = Convert.ToInt32(textBoxSigma5.Text);
            _settings.Sigma6 = Convert.ToInt32(textBoxSigma6.Text);
            _settings.UpdateUserSettings();
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            _settings = _settings.GetUserSettings();
            textBoxSigma1.Text = _settings.Sigma1.ToString();
            textBoxSigma2.Text = _settings.Sigma2.ToString();
            textBoxSigma3.Text = _settings.Sigma3.ToString();
            textBoxSigma4.Text = _settings.Sigma4.ToString();
            textBoxSigma5.Text = _settings.Sigma5.ToString();
            textBoxSigma6.Text = _settings.Sigma6.ToString();
        }
    }
}