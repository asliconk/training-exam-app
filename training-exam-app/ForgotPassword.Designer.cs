
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
            this.lblEMail = new DevExpress.XtraEditors.LabelControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.txtRecoveryPin = new DevExpress.XtraEditors.TextEdit();
            this.lblRecoveryPin = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecoveryPin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(147, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(412, 21);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Your new password will be sent to your e-mail address.";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(195, 202);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(308, 22);
            this.txtEMail.TabIndex = 19;
            // 
            // lblEMail
            // 
            this.lblEMail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.Appearance.Options.UseFont = true;
            this.lblEMail.Location = new System.Drawing.Point(195, 175);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(117, 21);
            this.lblEMail.TabIndex = 17;
            this.lblEMail.Text = "E-Mail Address:";
            // 
            // btnSend
            // 
            this.btnSend.Appearance.BackColor = System.Drawing.Color.Blue;
            this.btnSend.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Appearance.Options.UseBackColor = true;
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.Location = new System.Drawing.Point(195, 342);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(308, 37);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "SEND";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtRecoveryPin
            // 
            this.txtRecoveryPin.Location = new System.Drawing.Point(195, 257);
            this.txtRecoveryPin.Name = "txtRecoveryPin";
            this.txtRecoveryPin.Size = new System.Drawing.Size(308, 22);
            this.txtRecoveryPin.TabIndex = 22;
            this.txtRecoveryPin.Visible = false;
            // 
            // lblRecoveryPin
            // 
            this.lblRecoveryPin.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecoveryPin.Appearance.Options.UseFont = true;
            this.lblRecoveryPin.Location = new System.Drawing.Point(195, 230);
            this.lblRecoveryPin.Name = "lblRecoveryPin";
            this.lblRecoveryPin.Size = new System.Drawing.Size(95, 21);
            this.lblRecoveryPin.TabIndex = 21;
            this.lblRecoveryPin.Text = "Recovery Pin";
            this.lblRecoveryPin.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 314);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 22);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(195, 287);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 21);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password";
            this.lblPassword.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(195, 287);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 21);
            this.labelControl3.TabIndex = 23;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 470);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtRecoveryPin);
            this.Controls.Add(this.lblRecoveryPin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecoveryPin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEMail;
        private DevExpress.XtraEditors.LabelControl lblEMail;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.TextEdit txtRecoveryPin;
        private DevExpress.XtraEditors.LabelControl lblRecoveryPin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}