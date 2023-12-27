using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceAdmission:Service<Admission>,IServiceAdmission
    {
        public ServiceAdmission(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<NomComplet> Occupants(Chambre c, DateTime debu)
        {
            return GetMany(a => a.ChambreFk == c.NumeroChambre && DateTime.Compare(a.DateAdmission, debu) > 0)
                .Select(a => a.Patient.NomComplet);
        }

        public float recette(Clinique c, int annee)
        {
            return GetMany(a => a.Chambre.CLiniqueFk == c.CliniqueId && a.DateAdmission.Year == annee)
                .Sum(a => a.Chambre.Prix * a.NbJours);
        }
    }
}
