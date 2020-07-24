using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
namespace WebUI.Entities
{
    public class DBApplicationContext : IdentityDbContext<DbUser, DbRole, int, IdentityUserClaim<int>,
                    DbUserRole, IdentityUserLogin<int>,
                    IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DBApplicationContext(DbContextOptions<DBApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DbUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                //звязкі
                                                          
            });
        }
        public virtual DbSet<DbUser> Users { get; set; }
        public virtual DbSet<DbRole> Roles { get; set; }
        public virtual DbSet<DbUserRole> UserRoles { get; set; }
        public virtual DbSet<Pupil> Pupils { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<UserClasses> UserClasses { get; set; }
        public virtual DbSet<SubjectUser> SubjectUsers { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<Lessons> Lessons{ get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<MarkType> MarkTypes { get; set; }

    }
}
