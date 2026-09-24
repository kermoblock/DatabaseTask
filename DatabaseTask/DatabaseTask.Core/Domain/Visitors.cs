using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visitors
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Personal_Number { get; set; }
        public int Telphone_Number { get; set; }
        public string Relation_To_The_Prisoner { get; set; }
    }
}
