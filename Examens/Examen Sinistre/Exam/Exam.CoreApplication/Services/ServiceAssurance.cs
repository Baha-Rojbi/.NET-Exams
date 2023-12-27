using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceAssurance:Service<Assurance> ,IServiceAssurance
    {
        public ServiceAssurance(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PourcentageAssurances(TypeAssurance assuranceType)
        {
            var total = GetAll().Count();
            var nbreType = GetMany(a => a.Type == assuranceType).Count();
            return (nbreType / total) * 100;
        }

        public int NbExpertise(Assurance assurance, Expert expert)
        {
            return assurance.Sinistres.SelectMany(s => s.Expertises).Where(e => e.Expert.Equals(expert)).Count();
        }
    }
}
