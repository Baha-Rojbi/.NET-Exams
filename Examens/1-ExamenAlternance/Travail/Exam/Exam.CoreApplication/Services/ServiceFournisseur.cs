using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceFournisseur:Service<Fournisseur>,IServiceFournisseur
    {
        public ServiceFournisseur(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
    }
}
