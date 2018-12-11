using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Matching_Algorithm_core.Model
{
    public class Personne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonneType PersonneType { get; set; }
        public IEnumerable<Interest> PersonneInterests { get; set; }
        public IEnumerable<Personne> MatchingPersonnes { get; set; }
    }
}
