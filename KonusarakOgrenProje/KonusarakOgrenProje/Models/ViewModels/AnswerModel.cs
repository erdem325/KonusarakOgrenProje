using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models.ViewModels
{
    public class AnswerModel
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
        public bool? IsCorrectAnswer { get; set; }
    }
}
