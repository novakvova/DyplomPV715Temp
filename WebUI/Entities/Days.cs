using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class Days
    {
        [Key]
        public int Day_Id { get; set; }
        public string Day_Name { get; set; }
    }
}
