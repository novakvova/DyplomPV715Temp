using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class Pupil
    {
        [Key]
        public int Pupil_Id { get; set; }
        public string Pupil_FirstName { get; set; }
        public string Pupil_LastName { get; set; }
        public DateTime Pupil_Birthday { get; set; }
        public  bool Pupil_Sex { get; set; }
        public string Pupil_Address { get; set; }
        public string Pupil_Phone { get; set; }
        public int Pupil_ClassId { get; set; }
        public string Pupil_Email { get; set; }
        public string Pupil_Password { get; set; }
        public int Pupil_Role_Id { get; set; }
       public DbRole DbRole { get; set; }
       public Class Class { get; set; }

    }
}
