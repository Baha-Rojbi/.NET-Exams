using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public enum TypeChambre
    {
        Simple,
        Double
    }
    public class Chambre
    {
        [Key]
        public int NumeroChambre { get; set; }
        public float Prix { get; set; }
        public TypeChambre TypeChambre { get; set; }
        public virtual List<Admission> Admissions { get; set; }
        public virtual Clinique Clinique { get; set; }
        public int CliniqueFK { get; set; }

    }
}
