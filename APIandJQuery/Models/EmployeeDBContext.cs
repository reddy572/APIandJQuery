using System.Data.Entity;

namespace APIandJQuery.Models
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
}