using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class SubjectUser
    {
        public virtual DbUser User { get; set; }
        public int UserId { get; set; }
        public virtual Subjects Subjects { get; set; }
        [Key]
        public int SubjectId { get; set; }
    }
}
