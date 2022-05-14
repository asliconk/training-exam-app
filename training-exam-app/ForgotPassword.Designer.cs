
namespace training_exam_app
{
    partial class ForgotPassword
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEMail = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblEMail = new DevExpress.XtraEditors.LabelControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(412, 21);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Your new password will be sent to your e-mail address.";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(131, 206);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(308, 22);
            this.txtEMail.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(131, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 21);
            this.lblPassword.TabIndex = 18;
            // 
            // lblEMail
            // 
            this.lblEMail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.Appearance.Options.UseFont = true;
            this.lblEMail.Location = new System.Drawing.Point(131, 169);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(117, 21);
            this.lblEMail.TabIndex = 17;
            this.lblEMail.Text = "E-Mail Address:";
            // 
            // btnSend
            // 
            this.btnSend.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnSend.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Appearance.Options.UseBackColor = true;
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.Location = new System.Drawing.Point(131, 251);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(308, 37);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "SEND";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 432);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEMail;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblEMail;
        private DevExpress.XtraEditors.SimpleButton btnSend;
    }
}