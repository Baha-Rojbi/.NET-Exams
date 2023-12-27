    
using Exam.CoreApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Interfaces
{
   public interface IServiceChambre:IService<Chambre>
    {
        public float PourcentChSimple(Clinique c);
    }
}
