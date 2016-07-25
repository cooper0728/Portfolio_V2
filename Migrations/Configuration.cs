namespace Portfolio_v2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio_v2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Portfolio_v2.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }

            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                roleManager.Create(new IdentityRole { Name = "Moderator" });
            }

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.Email == "cooper0728@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "cooper0728@gmail.com",
                    Email = "cooper0728@gmail.com",
                    FirstName = "Charles",
                    LastName = "Cooper",
                    DisplayName = "COOPER0728"
                }, "Allen1981!");
            }

            if (!context.Users.Any(u => u.Email == "jtwichell@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "jtwichell@coderfoundry.com",
                    Email = "jtwichell@coderfoundry.com",
                    FirstName = "Jason",
                    LastName = "Twichell",
                    DisplayName = "J-Twich"
                }, "Abc&123!");
            }


            var userId = userManager.FindByEmail("cooper0728@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");

            var juserId = userManager.FindByEmail("jtwichell@coderfoundry.com").Id;
            userManager.AddToRole(juserId, "Moderator");


        }




    }
}

