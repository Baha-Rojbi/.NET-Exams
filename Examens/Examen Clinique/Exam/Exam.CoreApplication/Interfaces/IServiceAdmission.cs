using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;

namespace Exam.CoreApplication.Interfaces
{
    internal interface IServiceAdmission:IService<Admission>
    {
        IEnumerable<NomComplet> Occupants(Chambre c, DateTime debu);
        float recette(Clinique c, int annee);
    }
}
