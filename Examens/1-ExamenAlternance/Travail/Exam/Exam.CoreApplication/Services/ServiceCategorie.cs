using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceCategorie:Service<Categorie>,IServiceCategorie
    {
        public ServiceCategorie(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
