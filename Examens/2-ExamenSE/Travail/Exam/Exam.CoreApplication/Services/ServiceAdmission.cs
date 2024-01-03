using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceAdmission:Service<Admission>,IAdmissionService
    {
        public ServiceAdmission(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<NomComplet> nomComplet(Chambre chambre, DateTime date)
        {
            return GetMany(a => a.ChambreFk == chambre.NumeroChambre).Where(a=>DateTime.Compare(a.DateAdmission, date) > 0).Select(a => a.Patient.NomComplet);
        }

        public float recette(Clinique c, int annee)
        {
            return GetMany(a => a.DateAdmission.Year == annee && a.Chambre.CliniqueFk == c.CliniqueId)
                .Sum(a => a.NbJours * a.Chambre.Prix);
        }
    }
}
