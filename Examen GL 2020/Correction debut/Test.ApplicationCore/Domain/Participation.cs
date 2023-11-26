using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Participation
    {
        public int Montant { get; set; }

        public int ParticipantFk { get; set; }

        public int CagnotteFk { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual Cagnotte Cagnotte { get; set; } 
    }
}
