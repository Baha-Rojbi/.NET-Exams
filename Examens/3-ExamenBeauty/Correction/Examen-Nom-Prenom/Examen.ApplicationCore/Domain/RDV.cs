using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class RDV
    {
        public DateTime DateRDV { get; set; }
        public bool Confirmation { get; set; }
        public int ClientFk { get; set; }
        public int PrestationFk { get; set; }
        public virtual Client Client { get; set; }
        public virtual Prestation Prestation { get; set; }
    }
}
