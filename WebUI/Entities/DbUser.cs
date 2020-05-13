﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class DbUser : IdentityUser<string>
    {        public ICollection<DbUserRole> UserRoles { get; set; }
    }
}
