using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_exam_app.Concrete
{
    internal class Questions
    {
        public int Id { get; set; } 
        public int QuestionStatus { get; set; }
        public string QuestionImagePath { get; set; }
        public int QuestionModules  { get; set; }   
    }
}
