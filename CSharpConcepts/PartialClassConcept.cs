using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    partial class PartialClassConcept
    {
        public int Id { get; set; }
    }

    partial class PartialClassConcept
    {    
        public List<string> Names { get; set; }
        
    }

}
