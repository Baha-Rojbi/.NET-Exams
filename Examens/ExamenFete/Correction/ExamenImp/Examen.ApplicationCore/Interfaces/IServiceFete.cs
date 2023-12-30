using AM.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceFete:IService<Fete>
    {
        public Salle SalleUtilise();
        int NbrFete(Salle s, TypeFete T);
        int MaxDuree();
    }
}
