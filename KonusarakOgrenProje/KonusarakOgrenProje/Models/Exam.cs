using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models
{ 
    public class Exam : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }
        public string TextId { get; set; }

        [Required(ErrorMessage = "Başlık alanı boş olamaz!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Yazı alanı boş olamaz!")]
        public string Content { get; set; }

        public List<ExamQuestion> ExamQuestions { get; set; }
    }
}
