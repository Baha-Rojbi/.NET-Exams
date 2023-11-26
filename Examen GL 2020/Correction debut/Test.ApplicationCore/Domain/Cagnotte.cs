using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public enum Type
    {
        CadeauCommung,DepenseAPlusieurs,ProjetSolidaire,Autres
    }
    public class Cagnotte
    {
        public int CagnotteId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateLimite { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Photo { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive number allowed.")]
        public int SommeDemandee { get; set; }
        [Required(ErrorMessage = "LE titre est obligatoire")]
        public string Titre { get; set; }
        public Type Type { get; set; }
        public virtual IList<Participation> Participations { get; set; }
        public virtual Entreprise  Entreprise { get; set; }

    }
}
