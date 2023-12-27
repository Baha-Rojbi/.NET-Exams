﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceSinistre:Service<Sinistre>,IServiceSinistre
    {
        public ServiceSinistre(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
