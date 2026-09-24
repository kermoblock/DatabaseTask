using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Building
    {
        public int Id { get; set; }
        
        public Prison Prison { get; set; }
    }
}
