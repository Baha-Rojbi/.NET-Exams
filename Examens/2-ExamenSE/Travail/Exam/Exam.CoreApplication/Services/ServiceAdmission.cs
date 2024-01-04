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

        public IEnumerable<NomComplet> nomComplet(Chambre chambre, DateTime dateTime)
        {
            return GetMany(a => a.Chambre == chambre && a.DateAdmission >= dateTime)
                .Select(a => a.Patient.NomComplet);
        }

        public double CalculateCliniqueRevenue(Clinique clinique, int year)
        {
            return GetMany(p => p.DateAdmission.Year == year && p.Chambre.CliniqueFk == clinique.CliniqueId)
                .Sum(p => p.Chambre.Prix * p.NbJours);
        }
    }
}
