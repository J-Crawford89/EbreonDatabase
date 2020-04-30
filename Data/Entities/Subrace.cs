using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Subrace
    {
        [Key]
        public int SubraceId { get; set; }
        public string SubraceName { get; set; }
        public string SubraceDescription { get; set; }
        public string Source { get; set; }
        [ForeignKey("ParentRace")]
        public int RaceId { get; set; }
        public virtual Race ParentRace { get; set; }
    }
}
