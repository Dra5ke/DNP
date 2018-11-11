using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dotnetimals
{
    public static class DbInitializer
    {
        public static void Initialize(CatContext context)
        {
            context.Database.EnsureCreated();
            
            if(context.Cats.Any())
            {
                return;
            }

            var cats = new Cat[]
            {
                new Cat { Name = "Nomu", Price = 100, Colour = "white", Birthdate = new DateTime(day:3,month:10,year:2017), FavouriteDish = "m e a t" },
                new Cat { Name = "Nayna", Price = 35, Colour = "black", Birthdate = new DateTime(day:5,month:7,year:2018), FavouriteDish = "fish" },
                new Cat { Name = "Bob", Price = 2, Colour = "ginger", Birthdate = new DateTime(day:13,month:9,year:2018), FavouriteDish = "vegan" }
            };

            foreach(Cat cat in cats)
            {
                context.Add(cat);
            }

            context.SaveChanges();
        }
    }
}