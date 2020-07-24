using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class Class
    {
        [Key]
        public int Class_Id { get; set; }
        public int Class_Year { get; set; }
        public int Class_Letter { get; set; }
        public int Class_UserId { get; set; }
        public DbUser DbUser { get; set; }
    }
}
