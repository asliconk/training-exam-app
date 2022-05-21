
namespace training_exam_app
{
    partial class AddQuestion
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
            this.questionContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtAnswerOne = new DevExpress.XtraEditors.ButtonEdit();
            this.txtAnswerTwo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtAnswerThree = new DevExpress.XtraEditors.ButtonEdit();
            this.txtAnswerFour = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnAnswerStateOne = new System.Windows.Forms.RadioButton();
            this.rbtnAnswerStateThree = new System.Windows.Forms.RadioButton();
            this.rbtnAnswerStateTwo = new System.Windows.Forms.RadioButton();
            this.rbtnAnswerStateFour = new System.Windows.Forms.RadioButton();
            this.cboxModule = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerOne.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerTwo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerThree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerFour.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // questionContent
            // 
            this.questionContent.Location = new System.Drawing.Point(15, 31);
            this.questionContent.Name = "questionContent";
            this.questionContent.Size = new System.Drawing.Size(599, 126);
            this.questionContent.TabIndex = 0;
            this.questionContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Answer 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Answer 4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtAnswerOne
            // 
            this.txtAnswerOne.Location = new System.Drawing.Point(15, 184);
            this.txtAnswerOne.Name = "txtAnswerOne";
            this.txtAnswerOne.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAnswerOne.Size = new System.Drawing.Size(242, 22);
            this.txtAnswerOne.TabIndex = 12;
            this.txtAnswerOne.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAnswerOne_ButtonClick);
            // 
            // txtAnswerTwo
            // 
            this.txtAnswerTwo.Location = new System.Drawing.Point(351, 184);
            this.txtAnswerTwo.Name = "txtAnswerTwo";
            this.txtAnswerTwo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAnswerTwo.Size = new System.Drawing.Size(242, 22);
            this.txtAnswerTwo.TabIndex = 13;
            this.txtAnswerTwo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAnswerTwo_ButtonClick);
            // 
            // txtAnswerThree
            // 
            this.txtAnswerThree.Location = new System.Drawing.Point(15, 233);
            this.txtAnswerThree.Name = "txtAnswerThree";
            this.txtAnswerThree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAnswerThree.Size = new System.Drawing.Size(242, 22);
            this.txtAnswerThree.TabIndex = 14;
            this.txtAnswerThree.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAnswerThree_ButtonClick);
            // 
            // txtAnswerFour
            // 
            this.txtAnswerFour.Location = new System.Drawing.Point(351, 233);
            this.txtAnswerFour.Name = "txtAnswerFour";
            this.txtAnswerFour.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAnswerFour.Size = new System.Drawing.Size(242, 22);
            this.txtAnswerFour.TabIndex = 15;
            this.txtAnswerFour.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAnswerFour_ButtonClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 47);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtnAnswerStateOne
            // 
            this.rbtnAnswerStateOne.AutoSize = true;
            this.rbtnAnswerStateOne.Checked = true;
            this.rbtnAnswerStateOne.Location = new System.Drawing.Point(263, 187);
            this.rbtnAnswerStateOne.Name = "rbtnAnswerStateOne";
            this.rbtnAnswerStateOne.Size = new System.Drawing.Size(17, 16);
            this.rbtnAnswerStateOne.TabIndex = 17;
            this.rbtnAnswerStateOne.TabStop = true;
            this.rbtnAnswerStateOne.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswerStateThree
            // 
            this.rbtnAnswerStateThree.AutoSize = true;
            this.rbtnAnswerStateThree.Location = new System.Drawing.Point(263, 236);
            this.rbtnAnswerStateThree.Name = "rbtnAnswerStateThree";
            this.rbtnAnswerStateThree.Size = new System.Drawing.Size(17, 16);
            this.rbtnAnswerStateThree.TabIndex = 18;
            this.rbtnAnswerStateThree.TabStop = true;
            this.rbtnAnswerStateThree.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswerStateTwo
            // 
            this.rbtnAnswerStateTwo.AutoSize = true;
            this.rbtnAnswerStateTwo.Location = new System.Drawing.Point(597, 187);
            this.rbtnAnswerStateTwo.Name = "rbtnAnswerStateTwo";
            this.rbtnAnswerStateTwo.Size = new System.Drawing.Size(17, 16);
            this.rbtnAnswerStateTwo.TabIndex = 19;
            this.rbtnAnswerStateTwo.TabStop = true;
            this.rbtnAnswerStateTwo.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswerStateFour
            // 
            this.rbtnAnswerStateFour.AutoSize = true;
            this.rbtnAnswerStateFour.Location = new System.Drawing.Point(597, 236);
            this.rbtnAnswerStateFour.Name = "rbtnAnswerStateFour";
            this.rbtnAnswerStateFour.Size = new System.Drawing.Size(17, 16);
            this.rbtnAnswerStateFour.TabIndex = 20;
            this.rbtnAnswerStateFour.TabStop = true;
            this.rbtnAnswerStateFour.UseVisualStyleBackColor = true;
            // 
            // cboxModule
            // 
            this.cboxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule.FormattingEnabled = true;
            this.cboxModule.Location = new System.Drawing.Point(12, 284);
            this.cboxModule.Name = "cboxModule";
            this.cboxModule.Size = new System.Drawing.Size(245, 24);
            this.cboxModule.TabIndex = 21;
            this.cboxModule.SelectedIndexChanged += new System.EventHandler(this.cboxModule_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Module";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Subject";
            // 
            // cboxSubject
            // 
            this.cboxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSubject.FormattingEnabled = true;
            this.cboxSubject.Location = new System.Drawing.Point(351, 281);
            this.cboxSubject.Name = "cboxSubject";
            this.cboxSubject.Size = new System.Drawing.Size(245, 24);
            this.cboxSubject.TabIndex = 23;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 372);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxModule);
            this.Controls.Add(this.rbtnAnswerStateFour);
            this.Controls.Add(this.rbtnAnswerStateTwo);
            this.Controls.Add(this.rbtnAnswerStateThree);
            this.Controls.Add(this.rbtnAnswerStateOne);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnswerFour);
            this.Controls.Add(this.txtAnswerThree);
            this.Controls.Add(this.txtAnswerTwo);
            this.Controls.Add(this.txtAnswerOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestion";
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerOne.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerTwo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerThree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswerFour.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox questionContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.ButtonEdit txtAnswerOne;
        private DevExpress.XtraEditors.ButtonEdit txtAnswerTwo;
        private DevExpress.XtraEditors.ButtonEdit txtAnswerThree;
        private DevExpress.XtraEditors.ButtonEdit txtAnswerFour;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RadioButton rbtnAnswerStateOne;
        private System.Windows.Forms.RadioButton rbtnAnswerStateThree;
        private System.Windows.Forms.RadioButton rbtnAnswerStateTwo;
        private System.Windows.Forms.RadioButton rbtnAnswerStateFour;
        private System.Windows.Forms.ComboBox cboxModule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxSubject;
    }
}