using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, System.EventArgs e)
        {

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
           this.Close();
        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            var user = new User();
            if(user.Login(txtUserName.Text, txtPassword.Text))
            {
                var home = new Home();
                this.Hide();
                home.Show();
            }
        }

        private void lblSignUp_Click(object sender, System.EventArgs e)
        {
            var signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void lblForgotPassword_Click(object sender, System.EventArgs e)
        {
            var forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.Show();
        }
    }
}