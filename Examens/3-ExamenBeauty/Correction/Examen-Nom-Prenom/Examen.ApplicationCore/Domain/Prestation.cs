using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum type
    {
        Onglerie, Maquillage,Soin,Coiffure
    }
    public class Prestation
    {
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Intitule { get; set; }
        public int PrestationId { get; set; }
        [DataType(DataType.Currency)]
        public double Prix { get; set; }
        public type Type { get; set; }

        //2-d
        public int PrestataireFK { get; set; }
        [ForeignKey("PrestataireFK")] // config de la clé étrangère en utilisant les annotations
        public virtual Prestataire Prestataire { get; set; }
        public virtual  IList<RDV> RDVs { get; set; }
    }
}
