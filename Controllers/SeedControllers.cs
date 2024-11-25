// Controllers/SeedController.cs
using Microsoft.AspNetCore.Mvc;
using SeedDataApi.Data;

namespace SeedDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly SchoolContext _context;

        public SeedController(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SeedDatabase()
        {
            // Uncomment the following line to populate the database when starting the project
            // DbInitializer.Initialize(_context);
            // Comment the following line if you want to populate the database when starting the project
            DbInitializer.InitializeJson(_context);
            return Ok("Base de datos poblada exitosamente.");
        }

        [HttpDelete]
        public IActionResult DeleteAllStudents()
        {
            var students = _context.Students.ToList();
            _context.Students.RemoveRange(students);
            _context.SaveChanges();
            return Ok("Todos los estudiantes han sido eliminados.");
        }
    }
}
