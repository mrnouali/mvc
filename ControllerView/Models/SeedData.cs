using System;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace ControllerView.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Tasks.Any())  
                {
                    return;
                }

                var cat1 = new Category { Id = 1, Name = "ASP.NET Technologies" };
                var cat2 = new Category { Id = 2, Name = "Database design" };
                var cat3 = new Category { Id = 3, Name = "SPA" };
                
                context.Categories.AddRange(cat1, cat2, cat3);
                
                context.Tasks.AddRange(new []
                {
                    new Task
                    {
                        Title = "lab 7",
                        Deadline = DateTime.Now.AddDays(-1),
                        Description = "read about controllers and views",
                        CategoryId = cat1.Id,
                        ColorHex = "#dfffaf"
                    },
                    new Task
                    {
                        Title = "lab 8",
                        Deadline = DateTime.Now.AddDays(-1),
                        Description = "read about joins",
                        CategoryId = cat2.Id,
                        ColorHex = "#C4D5C4"
                    },
                    new Task
                    {
                        Title = "lab 7",
                        Deadline = DateTime.Now.AddDays(-1),
                        Description = "angular components",
                        CategoryId = cat3.Id,
                        ColorHex = "#b2d7eb"
                    }
                });

                context.SaveChanges();
            }
        }

    }
}