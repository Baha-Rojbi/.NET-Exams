using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Universitaire:Participant
    {
        public String Niveau { get; set; }
        public String NomInstitut { get; set; }
        public virtual Specialite Specialite { get; set; }
        [ForeignKey("Specialite")]
        public int SpecialiteFk { get; set; }
    }
}
