// Data/SchoolContext.cs
using Microsoft.EntityFrameworkCore;
using SeedDataApi.Models;

namespace SeedDataApi.Data
{
    public class SchoolContext(DbContextOptions<SchoolContext> options) : DbContext(options)
    {
        public required DbSet<Student> Students { get; set; }
    }
}
