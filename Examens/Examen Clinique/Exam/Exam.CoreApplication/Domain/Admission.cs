using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Admission
    {
        [DataType(DataType.Date)]
        public DateTime DateAdmission { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Le motif del’admission")]
        public string MotifAdmission { get; set; }
        public int NbJours { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Chambre Chambre { get; set; }
        [ForeignKey("Patient")]
        public int PatientFk { get; set; }
        [ForeignKey("Chambre")]
        public int ChambreFk { get; set; }
    }
}
