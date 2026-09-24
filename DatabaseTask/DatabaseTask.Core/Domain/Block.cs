using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        public int Id { get; set; }
        public Prison Prison { get; set; }
        public int Number { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        public int Security_Level { get; set; }
    }
}
