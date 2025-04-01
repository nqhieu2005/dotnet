using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonProject.Data;
using System;
using System.Linq;
namespace PersonProject.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new PersonProjectContext(
                serviceProvider.GetRequiredService<DbContextOptions<PersonProjectContext>>()))
            {
                // Look for any courses
                if (context.Course.Any())
                {
                    return; // DB has been seeded
                }
                context.Course.AddRange(
                    new Course
                    {
                        Name = "ASP.NET Core Fundamentals",
                        Description = "Learn the basics of ASP.NET Core.",
                        Price = 49.99M,
                        Rating = "4.5"
                    },
                    new Course
                    {
                        Name = "Advanced C# Programming",
                        Description = "Deep dive into C# with advanced concepts.",
                        Price = 79.99M,
                        Rating = "4.5"
                    },
                    new Course
                    {
                        Name = "Entity Framework Core",
                        Description = "Master data access with EF Core.",
                        Price = 59.99M,
                        Rating = "4.5"
                    },
                    new Course
                    {
                        Name = "Blazor WebAssembly",
                        Description = "Build interactive web UIs using Blazor.",
                        Price = 69.99M,
                        Rating = "4.5"
                    },
                    new Course
                    {
                        Name = "Microservices with .NET",
                        Description = "Develop microservices architecture using .NET.",
                        Price = 99.99M,
                        Rating = "4.5"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
