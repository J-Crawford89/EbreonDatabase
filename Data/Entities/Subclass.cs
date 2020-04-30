using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Subclass
    {
        [Key]
        public int SublcassId { get; set; }
        public string SublcassName { get; set; }
        public string SubclassDescription { get; set; }
        public string Source { get; set; }
        [ForeignKey("ParentClass")]
        public int ClassId { get; set; }
        public virtual Class ParentClass { get; set; }
    }
}
