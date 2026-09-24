using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Shift
    {
        public int Id { get; set; }
        public Guards Guards { get; set; }
        public int Start_time { get; set; }
        public int Finish_time { get; set; }
        public DateTime Date { get; set; }
    }
}
