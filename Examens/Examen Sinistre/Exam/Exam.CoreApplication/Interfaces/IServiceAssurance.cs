using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;

namespace Exam.CoreApplication.Interfaces
{
    public interface IServiceAssurance:IService<Assurance>
    {
        public double PourcentageAssurances(TypeAssurance  assuranceType);  
        public int  NbExpertise(Assurance  assurance,Expert expert);
    }
}
