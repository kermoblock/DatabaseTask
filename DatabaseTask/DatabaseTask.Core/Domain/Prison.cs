using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        public int Maxiumum_Capacity { get; set; }

        public ICollection<Guards> Guards { get; set; } = new List<Guards>();
        public ICollection<Block> Block { get; set; } = new List<Block>();
        public ICollection<Building> Building { get; set; } = new List<Building>();

    }
}
