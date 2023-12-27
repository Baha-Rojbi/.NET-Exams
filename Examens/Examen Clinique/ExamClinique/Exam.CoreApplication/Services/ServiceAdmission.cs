
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Services
{
    public class ServiceAdmission:Service<Admission>, IServiceAdmission

    {
        public ServiceAdmission(IUnitOfWork unitOfWork) : base(unitOfWork)
    {

    }
    //Q-Service2        
        public IEnumerable<NomComplet> Occupants(Chambre c, DateTime debut)
    {
        return GetMany(a => a.ChambreFK == c.NumeroChambre 
                        && DateTime.Compare(a.DateAdmission, debut) > 0)
                .Select(a => a.Patient.NomComplet);
    }
    //Q-Service2
        public float Recette(Clinique c, int annee)
    {
        return GetMany(a => a.Chambre.CliniqueFK == c.CliniqueId
                        && a.DateAdmission.Year == annee)
            .Sum(a => a.Chambre.Prix * a.NbJours);
    }
}
}
