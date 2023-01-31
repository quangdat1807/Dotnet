using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApplication1Context>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "When Harry Met Sally",
                        Date = DateTime.Parse("1989-2-12"),
                        Email = "Romantic Comedy",
                        
                    },

                    new Employee
                    {
                        Name = "Ghostbusters ",
                        Date = DateTime.Parse("1984-3-13"),
                        Email = "Comedy",
                       
                    },

                    new Employee
                    {
                        Name = "Ghostbusters 2",
                        Date = DateTime.Parse("1986-2-23"),
                        Email = "Comedy",
                      
                    },

                    new Employee
                    {
                        Name = "Rio Bravo",
                        Date = DateTime.Parse("1959-4-15"),
                        Email = "Western",
                       
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
