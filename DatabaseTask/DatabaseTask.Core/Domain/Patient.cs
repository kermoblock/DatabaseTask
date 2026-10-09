using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalID { get; set; }
        public DateTime Birthdate { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public HospitalTenants HospitalTenants { get; set; }
        public ICollection<Dose> Dose { get; set; } = new List<Dose>();
    }
}
