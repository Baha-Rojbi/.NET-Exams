
using Exam.CoreApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Interfaces
{
    public interface IServiceAdmission:IService<Admission>
    {
        IEnumerable<NomComplet> Occupants(Chambre c, DateTime debut);
        float Recette(Clinique c, int annee);
    }
}
