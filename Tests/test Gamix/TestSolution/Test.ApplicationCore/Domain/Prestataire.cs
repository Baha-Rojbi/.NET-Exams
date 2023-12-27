using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public enum Zone
    {
        Raoued,
        ArianaVille,
        LaSoukra
    }
    public class Prestataire
    {
        [Range(0,5)]
        public int Note { get; set; }
        public String Pageinstagram { get; set; }
        public int PrestataireId { get; set; }
        public String PrestataireNom { get; set; }
        public String PrestataireTel { get; set; }
        public Zone Zone { get; set; }
        public virtual IList<Prestation> Prestations { get; set; }
    }
}
