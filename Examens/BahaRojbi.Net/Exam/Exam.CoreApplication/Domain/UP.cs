using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class UP
    {
        [Key]
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Responsable { get; set; }
        public virtual IList<Enseignant> Enseignants { get; set; }
    }
}
