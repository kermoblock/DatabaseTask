using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeNr { get; set; }
        public int Phone { get; set; }
        public string Speciality { get; set; }
        public ICollection<Department> Department { get; set; } = new List<Department>();
    }
}
