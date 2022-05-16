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
    public partial class SettingsStudent : DevExpress.XtraEditors.XtraUserControl
    {
        private static SettingsStudent _instanceProductList;
        public static SettingsStudent InstanceQuestions
        {
            get
            {
                if (_instanceProductList == null)
                    _instanceProductList = new SettingsStudent();
                return _instanceProductList;
            }
        }
        public SettingsStudent()
        {
            InitializeComponent();
        }

    }
}
