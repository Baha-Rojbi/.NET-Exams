using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;

namespace Exam.CoreApplication.Interfaces
{
    public interface IAdmissionService:IService<Admission>
    {
       IEnumerable<NomComplet> nomComplet(Chambre chambre, DateTime date);
       float recette(Clinique c, int annee);
    }
}
