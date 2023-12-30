using Examen.ApplicationCore.Domain;
using Examen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceProduit:IService<Produit>
    {

        IEnumerable<Fournisseur> GetFournisseursByC(Categorie categorie);
        IEnumerable<Chimique> Get5Chimiques();

        double MoyennePrix(Categorie categorie);
    }
}
