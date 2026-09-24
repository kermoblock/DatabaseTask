using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prisoners
    {
        public int Id { get; set; }
        public Chamber Chamber { get; set; }
        public Punishment Punishment { get; set; }
        public Crime Crime { get; set; }
        [MaxLength(50)]
        public string First_Name { get; set; }
        [MaxLength(50)]
        public string Last_Name { get; set; }
        public DateTime DOB { get; set; }
        public int Personal_Number { get; set; }
        public DateTime Arrival_Date { get; set; }
        public bool Prisoner_Status { get; set; }
    }
}
