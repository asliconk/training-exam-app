﻿using DevExpress.XtraEditors;
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
    public partial class TrainingModule : DevExpress.XtraEditors.XtraUserControl
    {
        private static TrainingModule _instanceProductList;
        public static TrainingModule InstanceQuestions
        {
            get
            {
                if (_instanceProductList == null)
                    _instanceProductList = new TrainingModule();
                return _instanceProductList;
            }
        }
        public TrainingModule()
        {
            InitializeComponent();
        }

    }
}
