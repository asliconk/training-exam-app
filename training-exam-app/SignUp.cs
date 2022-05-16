using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
       
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {
            User user = new User();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.EmailAddress = txtEMail.Text;
            user.Password = txtPassword.Text;
            
            switch(cbUserType.Text)
            {
                case "Admin":
                    user.UserType = UserType.admin;
                    break;
                case "Examiner":
                    user.UserType = UserType.examiner;
                    break;
                default:
                    user.UserType = UserType.student;
                    break;
            }
            if (user.SignUp())
                this.Close();
        }

        private void SignUp_Load(object sender, System.EventArgs e)
        {

        }
    }
}