using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class Mark
    {
        public int PupilId { get; set; }
        public int SubjectId { get; set; }
        public int UserId { get; set; }
        [Key]
        public int MarkTypeId { get; set; }
        public Pupil Pupil { get; set; }
     
        public Subjects Subject { get; set; }
        public DbUser DbUser { get; set; }
        public MarkType MarkType { get; set; }
    }
}
