using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EFCore_AddAsyncBugReproduction
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new BuggyDbContext())
            {
                context.Database.Migrate();

                var bug = await context.Bugs.AddAsync(new Bug()
                {
                    Smashed = DateTime.UtcNow.AddDays(7)        // Not yet...
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
