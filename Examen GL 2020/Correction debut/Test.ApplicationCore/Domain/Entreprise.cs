using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Entreprise
    {
        public int EntrepriseId { get; set; }
        public String NomEntreprise { get; set; }
        public String AdresseEntreprise { get; set; }
        public String MailEntreprise { get; set; }
        public virtual IList<Cagnotte> Cagnottes { get; set; }
    }
}
