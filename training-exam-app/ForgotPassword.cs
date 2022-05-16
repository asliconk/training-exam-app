using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class ForgotPassword : DevExpress.XtraEditors.XtraForm
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private bool isState = false;

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            if(isState)
            {
                var user = new User();
                user.EmailAddress = txtEMail.Text;
                user.Password = txtPassword.Text;
                user.RecoverKey = txtRecoveryPin.Text;
                if (user.ResetPassword())
                    this.Close();
            }
            else
            {
                var user = new User();
                user.EmailAddress = txtEMail.Text;
                isState = user.ForgotPassword();
                if (isState)
                {
                    lblRecoveryPin.Visible = true;
                    lblPassword.Visible = true;
                    txtPassword.Visible = true;
                    txtRecoveryPin.Visible = true;
                    btnSend.Location = new System.Drawing.Point(195, 342);
                }
            }
        }

        private void ForgotPassword_Load(object sender, System.EventArgs e)
        {
            btnSend.Location = new System.Drawing.Point(195, 230);
        }
    }
}