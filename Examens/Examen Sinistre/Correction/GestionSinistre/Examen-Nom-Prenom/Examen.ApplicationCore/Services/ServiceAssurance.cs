using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Interfaces;
using Examen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceAssurance : Service<Assurance>, IServiceAssurance
    {
        public ServiceAssurance(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Expertise> GetNExperts(Assurance assurance, int n)
        {
            return assurance.ListeSinistres
                .SelectMany(p => p.Expertises)
                .OrderByDescending(p => p.Expert.DomaineExpertise)
                .Take(n);
        }

        public int NbExpertise(Assurance assurance, Expert expert)
        {
            return assurance.ListeSinistres
                .SelectMany(p => p.Expertises)
                .Where(p => p.Expert.Equals(expert))
                .Count();

        }

        public double PourcentageAssurance(int type)
        {
            var total = GetAll()
                .Count();

            var nbreType = GetMany(p => p.TypeAssurance.Equals(type))
                .Count();

            return (nbreType / total) * 100;
                
        }
    }
}

