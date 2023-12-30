using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum Zone
    {
        Raoued,ArianaVille,LaSoukra
    }
    public class Prestataire
    {


        //prop + 2 tab
        public int PrestataireId { get; set; }
        public string PrestataireNom { get; set; }
        public int PrestataireTel { get; set; }
        [Range(0,5)]
        public int Note { get; set; }
        public Zone Zone { get; set; }
        public string PageInstagram { get; set; }
        public virtual IList<Prestation> Prestations { get; set; }
    }
}
