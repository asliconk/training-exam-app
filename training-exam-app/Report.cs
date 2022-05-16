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
    public partial class Report : DevExpress.XtraEditors.XtraUserControl
    {
        private static Report _instanceProductList;
        public static Report InstanceQuestions
        {
            get
            {
                if (_instanceProductList == null)
                    _instanceProductList = new Report();
                return _instanceProductList;
            }
        }
        public Report()
        {
            InitializeComponent();
        }

    }
}
