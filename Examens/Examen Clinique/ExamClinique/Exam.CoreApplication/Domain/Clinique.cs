using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Clinique
    {
        public int CliniqueId { get; set; }
        public string Adresse { get; set; }
        public int NumTel { get; set; }
        public int Capacite { get; set; }

        public virtual List<Chambre> Chambres { get; set; }
    }
}
