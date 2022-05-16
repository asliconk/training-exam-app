
namespace training_exam_app
{
    partial class QuestionsControl
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
            this.components = new System.ComponentModel.Container();
            this.grdQuestions = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.questionApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.questionDontApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.gvQuestions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yenile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQuestions
            // 
            this.grdQuestions.ContextMenuStrip = this.contextMenuStrip1;
            this.grdQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdQuestions.Location = new System.Drawing.Point(0, 0);
            this.grdQuestions.MainView = this.gvQuestions;
            this.grdQuestions.Name = "grdQuestions";
            this.grdQuestions.Size = new System.Drawing.Size(843, 529);
            this.grdQuestions.TabIndex = 1;
            this.grdQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuestions});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenile,
            this.questionApprove,
            this.questionDontApprove,
            this.updateQuestion,
            this.deleteQuestion});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 152);
            // 
            // questionApprove
            // 
            this.questionApprove.Name = "questionApprove";
            this.questionApprove.Size = new System.Drawing.Size(238, 24);
            this.questionApprove.Text = "Question Approve";
            this.questionApprove.Click += new System.EventHandler(this.questionApprove_Click);
            // 
            // questionDontApprove
            // 
            this.questionDontApprove.Name = "questionDontApprove";
            this.questionDontApprove.Size = new System.Drawing.Size(238, 24);
            this.questionDontApprove.Text = "Question Don\'t Approve";
            this.questionDontApprove.Click += new System.EventHandler(this.questionDontApprove_Click);
            // 
            // updateQuestion
            // 
            this.updateQuestion.Name = "updateQuestion";
            this.updateQuestion.Size = new System.Drawing.Size(238, 24);
            this.updateQuestion.Text = "Update Question";
            this.updateQuestion.Click += new System.EventHandler(this.updateQuestion_Click);
            // 
            // deleteQuestion
            // 
            this.deleteQuestion.Name = "deleteQuestion";
            this.deleteQuestion.Size = new System.Drawing.Size(238, 24);
            this.deleteQuestion.Text = "Delete Question";
            this.deleteQuestion.Click += new System.EventHandler(this.deleteQuestion_Click);
            // 
            // gvQuestions
            // 
            this.gvQuestions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvQuestions.GridControl = this.grdQuestions;
            this.gvQuestions.Name = "gvQuestions";
            this.gvQuestions.OptionsView.ShowFooter = true;
            this.gvQuestions.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Question Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn1.MinWidth = 50;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Question";
            this.gridColumn2.FieldName = "QuestionContent";
            this.gridColumn2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn2.MinWidth = 50;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Module Name";
            this.gridColumn3.FieldName = "ModuleName";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Question Status";
            this.gridColumn4.FieldName = "QuestionStatus";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Question Subject";
            this.gridColumn5.FieldName = "SubjectName";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // yenile
            // 
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(238, 24);
            this.yenile.Text = "Yenile";
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // QuestionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdQuestions);
            this.Name = "QuestionsControl";
            this.Size = new System.Drawing.Size(843, 529);
            this.Load += new System.EventHandler(this.QuestionsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuestions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdQuestions;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuestions;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionApprove;
        private System.Windows.Forms.ToolStripMenuItem questionDontApprove;
        private System.Windows.Forms.ToolStripMenuItem updateQuestion;
        private System.Windows.Forms.ToolStripMenuItem deleteQuestion;
        private System.Windows.Forms.ToolStripMenuItem yenile;
    }
}
