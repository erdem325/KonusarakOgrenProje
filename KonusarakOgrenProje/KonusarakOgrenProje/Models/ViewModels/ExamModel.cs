using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models.ViewModels
{
    public class ExamModel
    {
        public List<TextModel> TextViewModels { get; set; }
        public Exam Question { get; set; }
    }
}
