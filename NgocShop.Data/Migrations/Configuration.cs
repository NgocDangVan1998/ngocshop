namespace NgocShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NgocShop.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NgocShop.Data.NgocShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NgocShop.Data.NgocShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new NgocShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new NgocShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "Ngoc",
            //    Email = "ngoc@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Information Technology"
            //};

            //manager.Create(user, "123456$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("ngoc@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }

        private void CreateProductCategorySample(NgocShop.Data.NgocShopDbContext context)
        {
            if(context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory(){Name = "Điện lạnh", Alias = "dien-lanh",Status=true},
                new ProductCategory(){Name = "Viễn thông", Alias = "vien-thong",Status=true},
                new ProductCategory(){Name = "Đồ gia dụng", Alias = "do-gia-dung",Status=true},
                new ProductCategory(){Name = "Mỹ phẩm", Alias = "my-pham",Status=true},
            };

                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}
