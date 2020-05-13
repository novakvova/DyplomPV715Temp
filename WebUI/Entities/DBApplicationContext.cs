﻿//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System;
//namespace WebUI.Entities
//{
//    public class DBApplicationContext : IdentityDbContext<DbUser, DbRole, string, IdentityUserClaim<string>,
//                    DbUserRole, IdentityUserLogin<string>,
//                    IdentityRoleClaim<string>, IdentityUserToken<string>>
//    {
//        public DBApplicationContext(DbContextOptions<DBApplicationContext> options) : base(options)
//        {
//        }
//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);

//            builder.Entity<DbUserRole>(userRole =>
//            {
//                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

//                userRole.HasOne(ur => ur.Role)
//                    .WithMany(r => r.UserRoles)
//                    .HasForeignKey(ur => ur.RoleId)
//                    .IsRequired();

//                userRole.HasOne(ur => ur.User)
//                    .WithMany(r => r.UserRoles)
//                    .HasForeignKey(ur => ur.UserId)
//                    .IsRequired();
//            });
//        }
//    }
//}
