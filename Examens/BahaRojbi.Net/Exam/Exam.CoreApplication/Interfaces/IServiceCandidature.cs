using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;

namespace Exam.CoreApplication.Interfaces
{
    public interface IServiceCandidature:IService<Candidature>
    {
        IEnumerable<Enseignant> enseignantConcours(int promotion);
        IEnumerable<int> tauxReussite();
        int posteRestant(int promotion, Specialite specialite);
    }
}
