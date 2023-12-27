using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceExpertise:Service<Expertise>,IServiceExpertise
    {
        public ServiceExpertise(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double RecetteExpert(DateTime date)
        {
            double sum = GetAll().Where(e => e.DateExpertise.Equals(date)).Sum(e => e.Duree);
            double tarifHorraire = GetMany(e => e.DateExpertise.Equals(date)).Sum(e => e.Expert.TarifHorraire);
            return sum * tarifHorraire;
        }
    }
}
