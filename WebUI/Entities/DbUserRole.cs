﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
    public class DbUserRole : IdentityUserRole<int>
    {   
        public virtual DbUser User { get; set; }
        public virtual DbRole Role { get; set; }
    }
}
