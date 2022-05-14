
namespace training_exam_app
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnSignIn = new DevExpress.XtraEditors.SimpleButton();
            this.lblEMail = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblForgotPassword = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblSignUp = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnSignIn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignIn.Appearance.Options.UseBackColor = true;
            this.btnSignIn.Appearance.Options.UseFont = true;
            this.btnSignIn.Location = new System.Drawing.Point(55, 423);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(308, 37);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "SIGN IN";
            // 
            // lblEMail
            // 
            this.lblEMail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.Appearance.Options.UseFont = true;
            this.lblEMail.Location = new System.Drawing.Point(55, 313);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(111, 21);
            this.lblEMail.TabIndex = 1;
            this.lblEMail.Text = "E-Mail Address";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 368);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForgotPassword.Appearance.Options.UseFont = true;
            this.lblForgotPassword.LineColor = System.Drawing.Color.Black;
            this.lblForgotPassword.LineVisible = true;
            this.lblForgotPassword.Location = new System.Drawing.Point(231, 466);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(132, 21);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.Text = "Forgot Password?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(55, 340);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(308, 22);
            this.txtUserName.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(55, 395);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // lblSignUp
            // 
            this.lblSignUp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUp.Appearance.Options.UseFont = true;
            this.lblSignUp.LineColor = System.Drawing.Color.Black;
            this.lblSignUp.LineVisible = true;
            this.lblSignUp.Location = new System.Drawing.Point(55, 466);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(67, 21);
            this.lblSignUp.TabIndex = 11;
            this.lblSignUp.Text = "SIGN UP ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 500);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.btnSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSignIn;
        private DevExpress.XtraEditors.LabelControl lblEMail;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblSignUp;
    }
}