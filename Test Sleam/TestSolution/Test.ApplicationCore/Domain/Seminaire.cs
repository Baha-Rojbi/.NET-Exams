using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Seminaire
    {
        [Key]
        public int Code { get; set; }
        public String Intitule { get; set; }
        public String Lieu { get; set; }
        public double Tarif { get; set; }
        public DateTime DateSemaine { get; set; }
        [Range(0,100)]
        public int NombreMaximal { get; set; }
        public virtual IList<Inscription> Inscriptions { get; set; }
    }
}
