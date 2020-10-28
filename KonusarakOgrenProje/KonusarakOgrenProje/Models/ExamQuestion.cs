using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models
{
    public class ExamQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamQuestionId { get; set; }
        public int QuestionNumber { get; set; }

        [Required(ErrorMessage = "Soru yazmalısınız...")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Cevap giriniz...")]
        public string AnswerA { get; set; }

        [Required(ErrorMessage = "Cevap giriniz...")]
        public string AnswerB { get; set; }

        [Required(ErrorMessage = "Cevap giriniz...")]
        public string AnswerC { get; set; }

        [Required(ErrorMessage = "Cevap giriniz...")]
        public string AnswerD { get; set; }

        [Required(ErrorMessage = "Doğru cevabı seçiniz...")]
        public string CorrectAnswer { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
