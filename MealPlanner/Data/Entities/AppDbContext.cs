using System.Collections.Generic;
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
        public DbSet<User> Users { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MealPlanItem> MealPlanItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Soups" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "MainDishes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Deserts" });

            //seed Meals
            Ingredient cal = new Ingredient(1, "califlower", 1.9, 5, 0.3, 24);
            Ingredient nuts = new Ingredient(2, "nuts", 13, 18, 5, 440);
            Ingredient soysauce = new Ingredient(3, "califlower", 4.8, 8, 0, 50);
            Ingredient eggwhite = new Ingredient(4, "eggwhite", 11, 0, 0, 51);

            modelBuilder.Entity<Ingredient>().HasData(cal);
            modelBuilder.Entity<Ingredient>().HasData(nuts);
            modelBuilder.Entity<Ingredient>().HasData(soysauce);
            modelBuilder.Entity<Ingredient>().HasData(eggwhite);

            var i1 = new IngredientDetail { Id = 1, Amount = 261, IngredientId = 1, MealId = 12 };
            var i2 = new IngredientDetail { Id = 2, Amount = 62, IngredientId = 2, MealId = 12};
            var i3 = new IngredientDetail { Id = 3, Amount = 23.7, IngredientId = 3, MealId = 12};
            var i4 = new IngredientDetail { Id = 4, Amount = 9, IngredientId = 4, MealId = 12};

            modelBuilder.Entity<IngredientDetail>().HasData(i1);
            modelBuilder.Entity<IngredientDetail>().HasData(i2);
            modelBuilder.Entity<IngredientDetail>().HasData(i3);
            modelBuilder.Entity<IngredientDetail>().HasData(i4);


            //Ingredient cal = new Ingredient(5, "califlower", 1.9, 5, 0.3, 24);
            //Ingredient cal = new Ingredient(6, "califlower", 1.9, 5, 0.3, 24);
            //Ingredient cal = new Ingredient(7, "califlower", 1.9, 5, 0.3, 24);
            //Ingredient cal = new Ingredient(8, "califlower", 1.9, 5, 0.3, 24);
            //Ingredient cal = new Ingredient(9, "califlower", 1.9, 5, 0.3, 24);
            //Ingredient cal = new Ingredient(10, "califlower", 1.9, 5, 0.3, 24);



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
                Calories = 980
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
                Calories = 910
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
                Calories = 920
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
                Calories = 913
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
                Calories = 800
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
                Calories = 897
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
                Calories = 678
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
                Calories = 545
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
                Calories = 876
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
                Calories = 456
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
                Calories = 498
            });

            modelBuilder.Entity<Meal>().HasData(new Meal
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
                Calories = 220
            });

        }

    }
}
 