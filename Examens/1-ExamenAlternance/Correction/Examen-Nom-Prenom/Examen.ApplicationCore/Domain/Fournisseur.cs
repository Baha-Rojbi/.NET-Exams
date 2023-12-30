using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Fournisseur
    {
        /* ID ou bien Id ou FournisseurID /FournisseurId
         * => clés primaires
         * 
         */
        //prop + 2 tab
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }
        [Key]
        public int Identifiant { get; set; }
        public bool IsApproved { get; set; }

        [Range(3,12)]
        public int Nbr { get; set; }

        [MinLength(3),MaxLength(12)]
        public string Nom { get; set; }


        public virtual IList<Produit> Produits { get; set; }



    }
}
