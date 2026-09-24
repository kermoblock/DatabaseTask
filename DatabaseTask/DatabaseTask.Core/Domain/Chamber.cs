using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Chamber
    {
        public int Id { get; set; }
        public Block Block { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int Maxiumum_Capacity { get; set; }
    }
}
