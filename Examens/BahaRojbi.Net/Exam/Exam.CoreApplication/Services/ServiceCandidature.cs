using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceCandidature:Service<Candidature>,IServiceCandidature
    {
        public ServiceCandidature(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }

        public IEnumerable<Enseignant> enseignantConcours(int promotion)
        {
            return GetMany(c => c.Concours.Promotion == promotion).Select(c => c.Enseignant);
        }

        public IEnumerable<int> tauxReussite()
        {
            return GetMany(c => c.Resultat).Select(c => c.Concours.Promotion);
        }

        public int posteRestant(int promotion, Specialite specialite)
        {
            return GetMany(c => c.Concours.Promotion == promotion && c.Enseignant.Specialite == specialite).Count();

        }
    }
}
