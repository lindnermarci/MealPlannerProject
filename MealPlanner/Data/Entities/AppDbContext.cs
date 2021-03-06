﻿using System.Collections.Generic;
using MealPlanner.Data.Entities;
using MealPlanner.Models;
using MealPlanner.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public override DbSet<User> Users { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MealPlanItem> MealPlanItems { get; set; }

        public DbSet<IngredientDetail> IngredientDetails { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Soups" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "MainDishes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Deserts" });


            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 1,
                Name = "Sausage & white bean casserole ",
                ShortDescription = "Our famous sausage!",
                LongDescription =
                    "Make this easy chipolata, bean and roasted veg one-pan dish for a healthy, flavour-packed meal the whole family will love. It offers four of your 5-a-day",
                CategoryId = 1,
                ImageUrl = "https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe/recipe-image/2019/04/sausage-casserole.jpg?itok=kWEQd0OP",
                IsMealOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 2,
                Name = "One-pan egg & veg brunch",
                ShortDescription = "You'll love it!",
                LongDescription =
                    "With courgette, peppers and eggs, this vegetarian dish is a filling, healthy breakfast for all the family – kids will enjoy dipping toast into soft egg yolk",
                CategoryId = 3,
                ImageUrl = "https://www.bbcgoodfood.com/sites/default/files/styles/recipe/public/recipe/recipe-image/2017/06/gfkids_onepanvegeggs.jpg?itok=XbNYQTmJ",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 3,
                Name = "Cheese Cake",
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 4,
                Name = "Cherry Meal",
                ShortDescription = "A summer classic!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 5,
                Name = "Christmas Apple Meal",
                ShortDescription = "Happy holidays with this Meal!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 6,
                Name = "Cranberry Meal",
                ShortDescription = "A Christmas favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 7,
                Name = "Peach Meal",
                ShortDescription = "Sweet as peach",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 8,
                Name = "Pumpkin Meal",
                ShortDescription = "Our Halloween favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                IsMealOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
            });


            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 9,
                Name = "Rhubarb Meal",
                ShortDescription = "My God, so sweet!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                IsMealOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 10,
                Name = "Strawberry Meal",
                ShortDescription = "Our delicious strawberry Meal!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
            {
                MealId = 11,
                Name = "Strawberry Cheese Cake",
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Meal chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Meal muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Meal cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                IsMealOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
            });

            modelBuilder.Entity<Meal>(m =>
            {
                m.HasData(
                    new
                    {
                        MealId = 12,
                        Name = "Cauliflower Egg White Scramble ",
                        ShortDescription = "Our famous egg scramble!",
                        LongDescription =
        "1) Chop cauliflower in food processor or use pre-chopped cauliflower.2) Weigh out cauliflower and cook in microwave for 10 minutes.3) Weigh out soy sauce and put in frying pan on medium heat.4) Add hot, cooked cauliflower and simmer till dry.5) Add egg whites and cook till done.6) Weigh nuts and sprinkle on top.",
                        CategoryId = 2,
                        ImageUrl = "~/images/cal.jpg",
                        IsMealOfTheWeek = true,
                        ImageThumbnailUrl = "~/images/cal.jpg",
                        ItemMealPlanId = 1,
                        Calories = 220,
                        PreparationTime = 20
                    });

               
            });



            modelBuilder.Entity<Ingredient>()
               .HasData(new Ingredient
               {
                   IngredientId = 1,
                   Name = "califlower",
                   ProteinContent = 4.0,
                   CarbohidrateContent = 0.3,
                   FatContent = 5.6,
               });

            modelBuilder.Entity<Ingredient>()
               .HasData(new Ingredient
               {
                   IngredientId = 2,
                   Name = "nuts",
                   ProteinContent = 5.0,
                   CarbohidrateContent = 4.2,
                   FatContent = 4.0,
               });

            modelBuilder.Entity<Ingredient>()
               .HasData(new Ingredient
               {
                   IngredientId = 3,
                   Name = "soy sauce",
                   ProteinContent = 5.0,
                   CarbohidrateContent = 3.2,
                   FatContent = 1.0,
               });

            modelBuilder.Entity<Ingredient>()
               .HasData( new Ingredient
               {
                   IngredientId = 4,
                   Name = "egg white",
                   ProteinContent = 5.0,
                   CarbohidrateContent = 2.4,
                   FatContent = 1.0,
               });

            modelBuilder.Entity<IngredientDetail>()
           .HasData(new
           {
               IngredientDetailId = 1,
               Amount = 122.0,
               IngredientId = 2,
               MealId = 12,
           }, new
           {
               IngredientDetailId = 2,
               Amount = 210.0,
               IngredientId = 3,
               MealId = 12,
           }, new
           {
               IngredientDetailId = 3,
               Amount = 261.0,
               IngredientId = 4,
               MealId = 12,
           }, new
           {
               IngredientDetailId = 4,
               Amount = 146.0,
               IngredientId = 1,
               MealId = 12,
           },
           new
           {
               IngredientDetailId = 5,
               Amount = 189.0,
               IngredientId = 4,
               MealId = 11,

           },
          new
          {
              IngredientDetailId = 6,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 11,

          },
          new
          {
              IngredientDetailId = 7,
              Amount = 213.3,
              IngredientId = 3,
              MealId = 11,

          },
          new
          {
              IngredientDetailId = 8,
              Amount = 122.2,
              IngredientId = 1,
              MealId = 11,

          },
          new
          {
              IngredientDetailId = 9,
              Amount = 321.1,
              IngredientId = 2,
              MealId = 10,

          },
          new
          {
              IngredientDetailId = 10,
              Amount = 012.1,
              IngredientId = 3,
              MealId = 10,

          },
          new
          {
              IngredientDetailId = 11,
              Amount = 212.0,
              IngredientId = 4,
              MealId = 10,

          },
          new
          {
              IngredientDetailId = 12,
              Amount = 101.0,
              IngredientId = 1,
              MealId = 10,

          },
          new
          {
              IngredientDetailId = 13,
              Amount = 321.0,
              IngredientId = 2,
              MealId = 9,

          },
          new
          {
              IngredientDetailId = 14,
              Amount = 211.0,
              IngredientId = 3,
              MealId = 9,

          },
          new
          {
              IngredientDetailId = 15,
              Amount = 141.0,
              IngredientId = 4,
              MealId = 9

          },
          new
          {
              IngredientDetailId = 16,
              Amount = 211.0,
              IngredientId = 1,
              MealId = 9,

          },
          new
          {
              IngredientDetailId = 17,
              Amount = 121.0,
              IngredientId = 2,
              MealId = 8,

          },
          new
          {
              IngredientDetailId = 18,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 8,

          },
          new
          {
              IngredientDetailId = 19,
              Amount = 261.0,
              IngredientId = 4,
              MealId = 8,

          },
          new
          {
              IngredientDetailId = 20,
              Amount = 261.0,
              IngredientId = 1,
              MealId = 8,

          },
          new
          {
              IngredientDetailId = 21,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 7,

          },
          new
          {
              IngredientDetailId = 22,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 7,

          },
          new
          {
              IngredientDetailId = 23,
              Amount = 261.0,
              IngredientId = 4,
              MealId = 7,

          },
          new
          {
              IngredientDetailId = 24,
              Amount = 261.0,
              IngredientId = 1,
              MealId = 7,

          },
          new
          {
              IngredientDetailId = 25,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 6,

          },
          new
          {
              IngredientDetailId = 26,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 6,

          },
          new
          {
              IngredientDetailId = 27,
              Amount = 261.0,
              IngredientId = 4,
              MealId = 6,

          },
          new
          {
              IngredientDetailId = 28,
              Amount = 261.0,
              IngredientId = 1,
              MealId = 6,

          },
          new
          {
              IngredientDetailId = 29,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 5,

          },
          new
          {
              IngredientDetailId = 30,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 5,

          },
          new
          {
              IngredientDetailId = 31,
              Amount = 261.0,
              IngredientId = 4,
              MealId = 5,

          },
          new
          {
              IngredientDetailId = 32,
              Amount = 321.0,
              IngredientId = 1,
              MealId = 5,

          },
          new
          {
              IngredientDetailId = 33,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 4,

          },
          new
          {
              IngredientDetailId = 34,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 4,

          },
          new
          {
              IngredientDetailId = 35,
              Amount = 261.0,
              IngredientId = 4,
              MealId = 4,

          },
          new
          {
              IngredientDetailId = 36,
              Amount = 261.0,
              IngredientId = 1,
              MealId = 4,

          },
          new
          {
              IngredientDetailId = 37,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 3,

          },
          new
          {
              IngredientDetailId = 38,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 3,

          },
          new
          {
              IngredientDetailId = 39,
              Amount = 311.0,
              IngredientId = 4,
              MealId = 3,

          },
          new
          {
              IngredientDetailId = 40,
              Amount = 221.0,
              IngredientId = 1,
              MealId = 3,

          },
          new
          {
              IngredientDetailId = 41,
              Amount = 269.0,
              IngredientId = 2,
              MealId = 2,

          },
          new
          {
              IngredientDetailId = 42,
              Amount = 271.0,
              IngredientId = 3,
              MealId = 2,

          },
          new
          {
              IngredientDetailId = 43,
              Amount = 291.0,
              IngredientId = 4,
              MealId = 2,

          },
          new
          {
              IngredientDetailId = 44,
              Amount = 159.0,
              IngredientId = 1,
              MealId = 2,

          },
          new
          {
              IngredientDetailId = 45,
              Amount = 211.0,
              IngredientId = 2,
              MealId = 1,

          },
          new
          {
              IngredientDetailId = 46,
              Amount = 261.0,
              IngredientId = 3,
              MealId = 1,

          },
          new
          {
              IngredientDetailId = 47,
              Amount = 271.0,
              IngredientId = 4,
              MealId = 1,

          },
          new
          {
              IngredientDetailId = 48,
              Amount = 261.0,
              IngredientId = 2,
              MealId = 1,

          });
        }

    }
}
 