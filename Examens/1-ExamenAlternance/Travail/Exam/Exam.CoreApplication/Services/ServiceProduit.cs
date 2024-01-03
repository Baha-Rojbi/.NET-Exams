using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.CoreApplication.Interfaces;

namespace Exam.CoreApplication.Services
{
    public class ServiceProduit : Service<Produit>, IServiceProduit
    {
        public ServiceProduit(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Fournisseur> getFournisssuers(Categorie categorie)
        {
            return categorie.Produits.SelectMany(p => p.Fournisseurs);
        }

        public IEnumerable<Chimique> getChimiques(int prix)
        {
            return GetAll().OfType<Chimique>().Where(p => p.Price > prix).OrderByDescending(p => p.Price).Take(5);
        }

        public double moyenne(Categorie categorie)
        {
            return GetAll().OfType<Biologique>().Where(b => b.Categorie == categorie).Average(p => p.Price);
        }
    }
}