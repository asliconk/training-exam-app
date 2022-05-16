using training_exam_app.Concrete;

namespace training_exam_app
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
        private User user = new User();
       
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, System.EventArgs e)
        {

        }
    }
}