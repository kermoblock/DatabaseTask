using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ResearchResult
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
    }
}
