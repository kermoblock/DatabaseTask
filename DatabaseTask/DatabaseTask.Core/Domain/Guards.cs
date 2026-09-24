using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Guards
    {
        public int Id { get; set; }

        public Prison Prison { get; set; }

        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)]
        public string Last_Name { get; set; }
        public int Worker_Number { get; set; }

        [MaxLength(70)]
        public string Job { get; set; }
    }
}
