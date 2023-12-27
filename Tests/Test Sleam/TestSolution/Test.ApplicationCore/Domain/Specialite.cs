using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApplicationCore.Domain
{
    public class Specialite
    {
        public int SpecialiteId { get; set; }
        public String Nom { get; set; }
        public String Abreviation { get; set; }
        public virtual IList<Universitaire> Universitaires { get;}
    }
}
