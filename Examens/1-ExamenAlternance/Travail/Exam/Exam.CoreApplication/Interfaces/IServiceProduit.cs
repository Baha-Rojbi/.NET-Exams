using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;

namespace Exam.CoreApplication.Interfaces
{
    public interface IServiceProduit:IService<Produit>
    {
        IEnumerable<Fournisseur> getFournisssuers(Categorie categorie);
        IEnumerable<Chimique> getChimiques(int prix);
        double moyenne (Categorie categorie);
    }
}
