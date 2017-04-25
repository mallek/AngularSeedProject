using Microsoft.EntityFrameworkCore;

namespace DevServer.Client.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Using EF migrations to a. Create the DB if not exist or b. migrate the tabase fit exists
            context.Database.Migrate();

            context.SaveChanges();
        }

    }
}