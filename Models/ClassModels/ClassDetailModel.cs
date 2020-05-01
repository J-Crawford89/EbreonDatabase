using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ClassModels
{
    public class ClassDetailModel
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public string KeyAbilities { get; set; }
        public string Source { get; set; }
    }
}
