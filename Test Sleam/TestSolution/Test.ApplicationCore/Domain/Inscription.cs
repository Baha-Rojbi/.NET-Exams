using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Inscription
    {
        public  DateTime DateInscription { get; set; }
        public double TauxReduction { get; set; }
        public virtual Seminaire Seminaire { get; set; }
        public virtual Participant Participant { get; set; }
        [ForeignKey("Seminaire")]
        public int SeminaireFk { get; set; }
        [ForeignKey("Participant")]
        public int ParticipantFk { get; set; }
    }
}
