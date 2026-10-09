using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HospitalWard
    {
        [Key]
        public Guid Id { get; set; }
        public int WardNr { get; set; }
        public int Floor { get; set; }
        public int BedCount { get; set; }

        public ICollection<HospitalTenants> HospitalTenants { get; set; } = new List<HospitalTenants>();
    }
}
