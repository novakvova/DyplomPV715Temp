using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class Subjects
    {
        //{
        //    public int Subject_Id { get; set; }
        //    public string Subject_Name { get; set; }
        //TODO: public virtual

        /// public Subjects() {   }

        [Key]
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public ICollection<SubjectUser> SubjectUsers { get; set; }
        
    }
}

