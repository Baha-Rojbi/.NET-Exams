using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.CoreApplication.Domain
{
    public class Produit
    {
        [DataType(DataType.Date,ErrorMessage = "La date doit etre valide")]
        public DateTime DateProd { get; set; }
        public string Destination { get; set; }
        public string Nom { get; set; }
        public double Price { get; set; }
        public int ProduitId { get; set; }
        public virtual IList<Fournisseur> Fournisseurs { get; set; }
        public virtual Categorie Categorie { get; set; }
        [ForeignKey("Categorie")]
        public int CategorieFk { get; set; }
    }
}
