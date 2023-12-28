using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginner_Projects
{
    public class Characteristics
    {
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string alignment { get; set; }
        public List<string> languages { get; set; }
        public List<string> damageResistances { get; set; }
        public List<string> damageImmunities { get; set; }
        public List<string> conditionImmunities { get; set; }
        public List<string> senses { get; set; }
        public int challengeRating { get; set; }
    }
}
