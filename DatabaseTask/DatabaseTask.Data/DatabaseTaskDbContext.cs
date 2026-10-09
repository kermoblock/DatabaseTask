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
        public DbSet<ResearchResult> ResearchResults { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<HospitalWard> HospitalWards { get; set; }
        public DbSet<HospitalTenants> HospitalTenants { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dose> Doses { get; set; }




    }
}
