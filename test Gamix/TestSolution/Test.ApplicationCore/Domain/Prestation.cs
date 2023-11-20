using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public enum Type
    {
        Coiffure,
        Maquillage,
        Onglerie,
        Soin
    }
    public class Prestation
    {
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
        public String Intitule { get; set; }
        public int PrestationId { get; set; }
        public Type PrestationType { get; set; }
        [DataType(DataType.Currency)]
        public double Prix { get; set; }
        
        public virtual Prestataire Prestataire { get; set; }
        public virtual IList<RDV> RDVs { get; set; }
        [ForeignKey("Prestataire")]
        public int PrestataireFK { get; set; }
    }
}
