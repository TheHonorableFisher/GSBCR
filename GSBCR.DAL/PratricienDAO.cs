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
    public class PratricienDAO
    {
        /// <summary>
        /// Recherche un praticien sur son ID
        /// </summary>
        /// <param name="pranum"></param>
        /// <returns></returns>
        public PRATICIEN FindById(Int16 pranum)
        {
            // Recherche un pratricien par son numéro
            PRATICIEN pra = null;

            using(var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          where p.PRA_NUM == pranum
                          select p;
                pra = req.SingleOrDefault<PRATICIEN>();
            }
            return pra;
        }

        /// <summary>
        /// Recherche tout les praticiens
        /// </summary>
        /// <returns></returns>
        public List<PRATICIEN> FindAll()
        {
            // Recherche de tout les praticiens
            List<PRATICIEN> pra = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          select p;
                pra = req.ToList<PRATICIEN>();

            }
            return pra;
        }

        /// <summary>
        /// Recherche tout les praticiens sur un code donnée
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<PRATICIEN> FindByType(string code)
        {
            // Recherche de tout les praticiens sur un code
            List<PRATICIEN> pra = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          where p.TYP_CODE == code
                          select p;
                pra = req.ToList<PRATICIEN>();
            }
            return pra;
        }
    }
}
