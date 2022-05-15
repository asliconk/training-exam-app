
namespace training_exam_app
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.studentTransactions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.examModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTrainingModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.examinerTransactions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnQuestionAdd1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnQuestions1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.adminTransactions = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnQuestionAdd2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnQuestions2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 39);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(769, 494);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.studentTransactions,
            this.examinerTransactions,
            this.adminTransactions});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 494);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // studentTransactions
            // 
            this.studentTransactions.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.examModule,
            this.btnTrainingModule,
            this.btnReport,
            this.btnSettings});
            this.studentTransactions.Expanded = true;
            this.studentTransactions.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.studentTransactions.Name = "studentTransactions";
            this.studentTransactions.Text = "Student Transactions";
            this.studentTransactions.Visible = false;
            // 
            // examModule
            // 
            this.examModule.Name = "examModule";
            this.examModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.examModule.Text = "Exam Module";
            // 
            // btnTrainingModule
            // 
            this.btnTrainingModule.Name = "btnTrainingModule";
            this.btnTrainingModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTrainingModule.Text = "Training Module";
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnReport.Text = "Report";
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSettings.Text = "Settings";
            // 
            // examinerTransactions
            // 
            this.examinerTransactions.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnQuestionAdd1,
            this.btnQuestions1});
            this.examinerTransactions.Expanded = true;
            this.examinerTransactions.Name = "examinerTransactions";
            this.examinerTransactions.Text = "Examiner Transactions";
            this.examinerTransactions.Visible = false;
            // 
            // btnQuestionAdd1
            // 
            this.btnQuestionAdd1.Name = "btnQuestionAdd1";
            this.btnQuestionAdd1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnQuestionAdd1.Text = "Question Add";
            this.btnQuestionAdd1.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // btnQuestions1
            // 
            this.btnQuestions1.Name = "btnQuestions1";
            this.btnQuestions1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnQuestions1.Text = "Questions";
            this.btnQuestions1.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // adminTransactions
            // 
            this.adminTransactions.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnQuestionAdd2,
            this.btnQuestions2});
            this.adminTransactions.Expanded = true;
            this.adminTransactions.Name = "adminTransactions";
            this.adminTransactions.Text = "Admin Transactions";
            this.adminTransactions.Visible = false;
            // 
            // btnQuestionAdd2
            // 
            this.btnQuestionAdd2.Name = "btnQuestionAdd2";
            this.btnQuestionAdd2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnQuestionAdd2.Text = "Question Add";
            this.btnQuestionAdd2.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // btnQuestions2
            // 
            this.btnQuestions2.Name = "btnQuestions2";
            this.btnQuestions2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnQuestions2.Text = "Questions";
            this.btnQuestions2.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1029, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 533);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Home";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement studentTransactions;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement examModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTrainingModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement examinerTransactions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnQuestionAdd1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnQuestions1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement adminTransactions;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnQuestions2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnQuestionAdd2;
    }
}

