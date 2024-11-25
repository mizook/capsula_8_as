// Data/DbInitializer.cs
using SeedDataApi.Models;
using System.Text.Json;

namespace SeedDataApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if students already exist
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new() { Name = "Juan Pérez", Email = "juan.perez@example.com" },
                new() { Name = "María Gómez", Email = "maria.gomez@example.com" },
                new() { Name = "Carlos López", Email = "carlos.lopez@example.com" }
            };

            foreach (var s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }

        public static void InitializeJson(SchoolContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if students already exist
            if (context.Students.Any())
            {
                return;
            }

            // Path to the JSON file
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "MOCK_DATA.json");

            // Read and deserialize the JSON file
            var jsonData = File.ReadAllText(filePath);
            var students = JsonSerializer.Deserialize<Student[]>(jsonData);

            if (students == null || students.Length == 0)
            {
                throw new InvalidOperationException("No se encontraron datos en el archivo JSON.");
            }

            // Add the data to the database
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
