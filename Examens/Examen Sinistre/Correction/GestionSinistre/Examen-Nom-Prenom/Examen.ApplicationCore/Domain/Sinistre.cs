using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Sinistre
    {
        public int SinistreId { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Invalid")]
        public DateTime DateDeclaration { get; set; }
        public string Lieu { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public virtual IList<Expertise> Expertises { get; set; }
      
        //  [ForeignKey("Assurance ")]
        public int AssuranceFk { get; set; }
       
        public virtual Assurance Assurance { get; set; }
    }
}
