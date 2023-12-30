using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Interfaces;
using Examen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ProduitService : Service<Produit>, IServiceProduit
    {
        public ProduitService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Chimique> Get5Chimiques()
        {
            return GetAll().OfType<Chimique>().OrderByDescending(p => p.Price).Take(5);
        }

        public IEnumerable<Fournisseur> GetFournisseursByC(Categorie categorie)
        {
            //return categorie.Produits.SelectMany(p => p.Fournisseurs);

            return GetMany(p => p.Categorie.Equals(categorie)).SelectMany(p => p.Fournisseurs);

        }

        public double MoyennePrix(Categorie categorie)
        {
            //return GetAll().OfType<Biologique>().Where(p => p.Categorie.Equals(categorie))
            // .Average(p => p.Price);

            // return GetMany(p => p.Categorie.Equals(categorie)).OfType<Biologique>().Average(p => p.Price);

            return categorie.Produits.OfType<Biologique>().Average(p => p.Price);
                }
    }
}
