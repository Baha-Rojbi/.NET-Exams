using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Expertise
    {
        [DataType(DataType.Date,ErrorMessage = "Must be a valid date")]
        public DateTime DateExpertise { get; set; }
        [DataType(DataType.MultilineText)]
        [MaxLength(100)]
        [MinLength(3)]
        public string AvisTechnique { get; set; }
        public double MontantEstime { get; set; }
        public double Duree { get; set; }
        public virtual Sinistre Sinistre { get; set; }
        public virtual Expert Expert { get; set; }
        [ForeignKey("Sinistre")]
        public int SinistreFk { get; set; }
        [ForeignKey("Expert")]
        public int ExpertFk { get; set; }
    }
}
