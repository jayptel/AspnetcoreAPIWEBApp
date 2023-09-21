namespace AspnetcoreAPIWEBApp
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated(); // Ensure the database is created

            // Check if data already exists
            if (context.Tasks.Any())
            {
                return; // Database has been seeded
            }

            // Seed initial data
            var tasks = new Task[]
            {
            new Task { Title = "Task 1", Description = "Description 1", IsCompleted = false },
            new Task { Title = "Task 2", Description = "Description 2", IsCompleted = true },
                // Add more tasks as needed
            };

            context.Tasks.AddRange(tasks);
            context.SaveChanges();
        }
    }
}
