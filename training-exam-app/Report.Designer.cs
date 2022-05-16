
namespace training_exam_app
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.lblModuleName = new DevExpress.XtraEditors.LabelControl();
            this.lblSuccessPercent = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.Appearance.Options.UseFont = true;
            this.lblFirstName.Location = new System.Drawing.Point(44, 79);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(143, 21);
            this.lblFirstName.TabIndex = 40;
            this.lblFirstName.Text = "Student First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Appearance.Options.UseFont = true;
            this.lblLastName.Location = new System.Drawing.Point(44, 135);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(141, 21);
            this.lblLastName.TabIndex = 41;
            this.lblLastName.Text = "Student Last Name";
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(391, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(112, 21);
            this.lblHeader.TabIndex = 42;
            this.lblHeader.Text = "Student Report";
            // 
            // lblModuleName
            // 
            this.lblModuleName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModuleName.Appearance.Options.UseFont = true;
            this.lblModuleName.Location = new System.Drawing.Point(142, 230);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(101, 21);
            this.lblModuleName.TabIndex = 43;
            this.lblModuleName.Text = "Module Name";
            // 
            // lblSuccessPercent
            // 
            this.lblSuccessPercent.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccessPercent.Appearance.Options.UseFont = true;
            this.lblSuccessPercent.Location = new System.Drawing.Point(635, 230);
            this.lblSuccessPercent.Name = "lblSuccessPercent";
            this.lblSuccessPercent.Size = new System.Drawing.Size(120, 21);
            this.lblSuccessPercent.TabIndex = 44;
            this.lblSuccessPercent.Text = "Success Percent";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSuccessPercent);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(956, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.LabelControl lblModuleName;
        private DevExpress.XtraEditors.LabelControl lblSuccessPercent;
    }
}
