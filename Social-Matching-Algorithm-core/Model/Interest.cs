using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Matching_Algorithm_core.Model
{
    public class Interest
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public IEnumerable<PersonneInterest> PersonneInterests { get; set; }
    }
}
