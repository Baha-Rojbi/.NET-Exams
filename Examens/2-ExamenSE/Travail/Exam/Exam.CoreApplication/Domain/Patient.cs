using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Patient
    {
        [DataType(DataType.EmailAddress)]
        public string AdresseEmail { get; set; }
        public string CIN { get; set; }
        public DateTime DateNaissacne { get; set; }
        public NomComplet NomComplet { get; set; }
        [Key]
        public int NumDossier { get; set; }
        public int NumTel { get; set; }
  
        public virtual IList<Admission> Admissions { get; set; }
    }
}
