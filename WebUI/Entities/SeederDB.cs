﻿//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;


//namespace WebUI.Entities
//{
//    public class SeederDB
//    {

//        public static void SeedRoles(UserManager<DbUser> userManager,
//         RoleManager<DbRole> roleManager)
//        {
//            var count = roleManager.Roles.Count();

//            if (count <= 0)
//            {
//                var roleName = "Admin";

//                var result = roleManager.CreateAsync(new DbRole
//                {
//                    Name = roleName
//                }).Result;

//                roleName = "User";
//                result = roleManager.CreateAsync(new DbRole
//                {
//                    Name = roleName
//                }).Result;
//            }
//        }

//        public static void SeedProfiles(UserManager<DbUser> userManager, EFDbContext context)
//        {
//            if (userManager.FindByEmailAsync("dima@gmail.com").Result == null)
//            {
//                string email = "dima@gmail.com";
//                string roleName = "User";

//                //var user = new DbUser
//                //{
//                //    Email = email,
//                //    UserName = email,
//                //    PhoneNumber = "+11(111)111-11-11"
//                //};

//                //var result = userManager.CreateAsync(user, "Qwerty1-").Result;

//                var userProfile = new UserProfile
//                {
                   
//                    DateOfBirth = DateTime.Now,
//                    GenderId = 1,
//                    CityId = 39, 
//                    //Image = "",
//                    User = new DbUser
//                    {
//                        Email = email,
//                        UserName = email,
//                        PhoneNumber = "+11(111)111-11-11"
//                    }
//                };

//                var result = userManager.CreateAsync(userProfile.User, "Qwerty1-").Result;
//                context.UserProfile.Add(userProfile);
//                context.SaveChanges();
//                result = userManager.AddToRoleAsync(userProfile.User, roleName).Result;
//            };


//        }

    

//        public static void SeedCities(UserManager<DbUser> userManager, EFDbContext context)
//        {
//            string[] cities = {"Вінниця‎", "Дніпро", "Донецьк", "Житомир", "Запоріжжя", "Івано-Франківськ", "Київ",
//                               "Кропивницький", "Луганськ", "Луцьк", "Львів", "Миколаїв", "Одеса", "Полтава", "Рівне",
//                               "Суми", "Тернопіль", "Ужгород", "Харків", "Херсон", "Хмельницький", "Черкаси",
//                               "Чернівці", "Чернігів"};

//            var count = context.City.Count();

//            if (count == 0)
//            {
//                foreach (var item in cities)
//                {
//                    context.Add(new City
//                    {
//                        Name = item
//                    });
//                    context.SaveChanges();
//                }
//            }
//        }

//        public static void SeedGenders(UserManager<DbUser> userManager, EFDbContext context)
//        {
//            var count = context.Gender.Count();
//            if (count == 0)
//            {
//                var gender1 = new Gender()
//                {
//                    Type = "Man"
//                };
//                var gender2 = new Gender()
//                {
//                    Type = "Woman"
//                };
//                context.Gender.AddRange(new List<Gender>
//                {
//                    gender1,
//                    gender2
//                });
//            }
//            context.SaveChanges();
//        }

//        public static void SeedData(IServiceProvider services, IWebHostEnvironment env, IConfiguration config)
//        {
//            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
//            {
//                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
//                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
//                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
//                //var emailSender = scope.ServiceProvider.GetRequiredService<IEmailSender>();
//                SeederDB.SeedRoles(manager, managerRole);
//                SeederDB.SeedProfiles(manager, context);
//                SeederDB.SeedGenders(manager, context);
//                SeederDB.SeedCities(manager, context);
               
//            }
//        }
//    }


//}

