using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class MarkType
    {
        [Key]
        public int MarkType_Id { get; set; }
        public int MarkType_Number { get; set; }
        public string MarkType_Text { get; set; }
        
    }
}
