using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Client
    {
        public String Adresse { get; set; }
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Tel { get; set; }
        public virtual IList<RDV> RDVs { get; set; }
    }
}
