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
    public class MedicamentDAO
    {
        /// <summary>
        /// Recherche un medicament sur son ID
        /// </summary>
        /// <param name="depot"></param>
        /// <returns></returns>
        public MEDICAMENT FindById(string depot)
        {
            //rechercher un médicament par son nom de dépot
            MEDICAMENT med = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("laFamille")
                          where m.MED_DEPOTLEGAL == depot
                          select m;
                med = req.SingleOrDefault<MEDICAMENT>();

            }
            return med;
        }

        /// <summary>
        /// Recherche tout les medicaments
        /// </summary>
        /// <returns></returns>
        public List<MEDICAMENT> FindAll()
        {
            //charger tous les médicaments
            List<MEDICAMENT> meds = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("laFamille")
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            return meds;
            
        }

        /// <summary>
        /// Recherche tout les médicaments appartenant à une même famille
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<MEDICAMENT> FindByFamille(string code)
        {
            // Charger tous les médicaments d'une famille par un code
            List<MEDICAMENT> meds = null;

            using(var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("laFamille")
                          where m.FAM_CODE == code
                          select m;
                meds = req.ToList<MEDICAMENT>();
            }

            return meds;
        }
    }
}
