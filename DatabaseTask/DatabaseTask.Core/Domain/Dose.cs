using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Dose
    {
        [Key]
        public Guid Id { get; set; }
        public string DailyDose { get; set; }
        public DateTime DoseStart { get; set; }
        public DateTime DoseEnd { get; set; }
        public ICollection<Medicine> Medicine { get; set; } = new List<Medicine>();

    }
}
