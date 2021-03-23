using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public class FamilleDAO
    {
        /// <summary>
        /// Recherche une famille de medicament sur son ID
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public FAMILLE FindById(string code)
        {
            // Recherche une famille de médicaments par son code
            FAMILLE fam = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.FAMILLE.Include("laFamille")
                          where m.FAM_CODE == code
                          select m;
                fam = req.SingleOrDefault<FAMILLE>();

            }
            return fam;
        }

        /// <summary>
        /// Recherche toutes les familles de medicaments
        /// </summary>
        /// <returns></returns>
        public List<FAMILLE> FindAll()
        {
            // Charge toutes les familles
            List<FAMILLE> fams = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.FAMILLE.Include("laFamille")
                          select m;
                fams = req.ToList<FAMILLE>();

            }
            return fams;
        }

    }
}
