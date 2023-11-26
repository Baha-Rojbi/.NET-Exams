using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Participant
    {
        public String MailParticipant { get; set; }
        public String Nom { get; set; }
        public int ParticipantId { get; set; }
        public String Prenom { get; set; }
        public virtual IList<Participation> Participations { get; set; }
    }
}
