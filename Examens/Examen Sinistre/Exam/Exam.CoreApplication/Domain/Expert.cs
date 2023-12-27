using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Expert
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string DomaineExpertise { get; set; }
        public double TarifHorraire { get; set; }
  public virtual List<Expertise> Expertises { get; set; }

    }
}
