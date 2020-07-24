using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class Lessons
    {
        [Key]
        public int Lesson_Id { get; set; }
        public int SubjectId { get; set; }
        public int Lesson_Day_Id { get; set; }
        public Subjects Subject { get; set; }
        public Days Day_Id { get; set; }

    }
}
