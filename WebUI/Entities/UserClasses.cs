using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class UserClasses
    {
        public  Class Class { get; set; }
        public int ClassId { get; set; }
        public  DbUser User { get; set; }
        [Key]
        public int UserId { get; set; }

    }
}
