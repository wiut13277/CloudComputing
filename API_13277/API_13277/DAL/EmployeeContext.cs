using Microsoft.EntityFrameworkCore;

namespace API_13277.DAL
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
    }
}
