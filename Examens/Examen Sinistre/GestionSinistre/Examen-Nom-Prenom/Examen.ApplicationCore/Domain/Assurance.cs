﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{

    public enum TypeAssurance
    {
        Voiture, Habitation, Sante,Vie
    }
    public class Assurance
    {
        public int AssuranceId { get; set; }

        [Display(Name = "Date Début")]
        public DateTime DateEffet { get; set; }
        [Display(Name = "Date Fin")]
        public DateTime DateEcheance { get; set; }
        public TypeAssurance TypeAssurance { get; set; }

        public virtual IList<Sinistre> ListeSinistres { get; set; }
    }
}
