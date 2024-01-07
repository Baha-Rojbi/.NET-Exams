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
    public class ServiceExpertise : Service<Expertise>, IServiceExpertise
    {
        public ServiceExpertise(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public double RecetteExpert(DateTime date)
        {
           double sum = GetAll().Where(p => p.DateExpertise.Equals(date)).Sum(p => p.Duree);
           double tarif= GetMany(p => p.DateExpertise.Equals(date)).Sum(p => p.Expert.TarifHoraire);

            return sum * tarif;



        }



    }
}
