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
    public class MotifVisiteDAO
    {
        /// <summary>
        /// Recherche un motif de visite sur son ID
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public MOTIF_VISITE FindById(string code)
        {
            // Recherche un motif visite par son code
            MOTIF_VISITE vis = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                // Desactiver le chargement différé
                // context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE
                          where m.MOT_CODE == code
                          select m;
                vis = req.SingleOrDefault<MOTIF_VISITE>();
            }

            return vis;
        }

        /// <summary>
        /// Recherche tout les motifs de visite
        /// </summary>
        /// <returns></returns>
        public List<MOTIF_VISITE> FindAll()
        {
            // Charger tout les motifs de visite
            List<MOTIF_VISITE> lmv = null;
            
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE
                          select m;
                lmv = req.ToList<MOTIF_VISITE>();

            }
            return lmv;
        }
    }
}
