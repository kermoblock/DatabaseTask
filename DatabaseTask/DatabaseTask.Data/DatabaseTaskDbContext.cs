using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.

        public DbSet<Bookable> Bookable { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Payroll> Payroll { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<ServiceOrder> ServiceOrder { get; set; }
        public DbSet<Services> Services { get; set; }













    }
}
