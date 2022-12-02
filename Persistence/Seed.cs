using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Manuals.Any()) return;
            
            var manuals = new List<Manual>
            {
                new Manual
                {
                    Title = "Past Manual 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Manual 2 months ago",
                    Category = "programing",
                },
                new Manual
                {
                    Title = "Past Manual 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Manual 1 month ago",
                    Category = "it",
                },
                new Manual
                {
                    Title = "Future Manual 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Manual 1 month in future",
                    Category = "it",
                },
                new Manual
                {
                    Title = "Future Manual 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Manual 2 months in future",
                    Category = "adonis",
                },
                new Manual
                {
                    Title = "Future Manual 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Manual 3 months in future",
                    Category = "programing",
                },
                new Manual
                {
                    Title = "Future Manual 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Manual 4 months in future",
                    Category = "programing",
                },
                new Manual
                {
                    Title = "Future Manual 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Manual 5 months in future",
                    Category = "programing",
                },
                new Manual
                {
                    Title = "Future Manual 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Manual 6 months in future",
                    Category = "adonis",
                },
                new Manual
                {
                    Title = "Future Manual 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Manual 2 months ago",
                    Category = "travel",
                },
                new Manual
                {
                    Title = "Future Manual 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Manual 8 months in future",
                    Category = "film",
                }
            };

            await context.Manuals.AddRangeAsync(manuals);
            await context.SaveChangesAsync();
        }
    }
}