using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Expertise
    {
        [DataType(DataType.Date,ErrorMessage ="Invalid")]
        public DateTime DateExpertise { get; set; }


        [MinLength(3),MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string AvisTechnique { get; set; }
        public double MontantEstime { get; set; }
        public double Duree { get; set; }

       // [ForeignKey("MySinistre")]
        public int SinistreFk { get; set; }

        //[ForeignKey("Expert")]
        public int ExpertFk { get; set; }

       
        public virtual Sinistre MySinistre { get; set; }

        public virtual Expert Expert { get; set; }
    }
}
