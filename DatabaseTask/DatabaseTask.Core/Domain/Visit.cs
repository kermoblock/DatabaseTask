using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Reason { get; set; }
        public string Summary { get; set; }
        public ICollection<Employee> Employee { get; set; } = new List<Employee>();
        public ICollection<Patient> Patient { get; set; } = new List<Patient>();

    }
}
