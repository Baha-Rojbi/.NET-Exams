using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exam.CoreApplication.Domain
{
    [Owned]
    public class NomComplet
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }


    }
}
