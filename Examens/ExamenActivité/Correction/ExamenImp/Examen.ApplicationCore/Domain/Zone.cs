using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    //config du type détenu en utlisant les annotations 
    //1 ère méthode
    [Owned]
    public class Zone
    {
        public string Ville { get; set; }
        public string Pays { get; set; }
    }
}
