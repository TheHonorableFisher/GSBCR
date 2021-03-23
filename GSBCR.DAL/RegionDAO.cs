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
    public class RegionDAO
    {
        /// <summary>
        /// Recherche une région par son code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public REGION FindById(string code)
        {
            // Recherche une region par son code
            REGION reg = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("LeType")
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();
            }
            return reg;
        }

        /// <summary>
        /// Charge toutes les régions
        /// </summary>
        /// <returns></returns>
        public List<REGION> FindAll()
        {
            // Charge toutes les régions
            List<REGION> reg = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("LeType")
                          select r;
                reg = req.ToList<REGION>();
            }
            return reg;
        }

        /// <summary>
        /// Charge toutes les régions sur un secteur donné
        /// </summary>
        /// <param name="secteurCode"></param>
        /// <returns></returns>
        public List<REGION> FindBySecteur(string secteurCode)
        {
            // Charge toutes les régions sur un secteur donnée
            List<REGION> reg = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("LeType")
                          where r.LeSecteur.SEC_CODE == secteurCode
                          select r;
                reg = req.ToList<REGION>();
            }
            return reg;
        }
    }
}
