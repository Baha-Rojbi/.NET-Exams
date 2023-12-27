﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public enum TypeAssurance
    {
        Voiture,Habitation,Sante,Vie
    }
    public class Assurance
    {
        public int AssuranceId { get; set; }
        [Display(Name = "Date Debut")]
        public DateTime DateEffet { get; set; }
        [Display(Name = "Date Fin")]
        public DateTime DateEchenace { get; set; }
        public TypeAssurance Type { get; set; }
        public virtual List<Sinistre>Sinistres { get; set; }
    }
}
