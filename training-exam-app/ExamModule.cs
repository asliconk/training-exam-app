using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_exam_app
{
    public partial class ExamModule : DevExpress.XtraEditors.XtraUserControl
    {
        private static ExamModule _instanceProductList;
        public static ExamModule InstanceQuestions
        {
            get
            {
                if (_instanceProductList == null)
                    _instanceProductList = new ExamModule();
                return _instanceProductList;
            }
        }

        public ExamModule()
        {
            InitializeComponent();
        }
    }
}
