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
        public int Id { get; set; }

        public Visitors Visitors { get; set; }
        public Prisoners Prisoners { get; set; }
        public DateTime Date { get; set; }
        public int Start_Time { get; set; }
        public int Finish_Time { get; set; }
        [MaxLength(60)]
        public string Visiting_Status { get; set; }
    }
}
