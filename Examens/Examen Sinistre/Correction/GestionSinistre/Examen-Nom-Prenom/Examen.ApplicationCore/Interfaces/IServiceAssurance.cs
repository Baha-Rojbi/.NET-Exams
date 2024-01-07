using Examen.ApplicationCore.Domain;
using Examen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceAssurance:IService<Assurance>
    {
        public double PourcentageAssurance(int type);
        public int NbExpertise(Assurance assurance, Expert expert);
    }
}
