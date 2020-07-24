using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class DbUser : IdentityUser<int>
    {
       
        public ICollection<DbUserRole> UserRoles { get; set; }
        public  ICollection<SubjectUser> UserSubjects { get; set; }
        public int User_ClassId { get; set; }
    }
}
