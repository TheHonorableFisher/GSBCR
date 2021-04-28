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
    public class VisiteurDAO
    {
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public VISITEUR FindById(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }

        /// <summary>
        /// Permet de mettre à jour le mot de passe d'un visiteur grâce à son matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="mdp">Nouveau mot de passe du vistieur</param>
        public void modifierMdp(String matricule, String mdp)
        {
            using (var context = new GSB_visite_groupe1Entities())
            {
                var v = context.VISITEUR.First(obj => obj.VIS_MATRICULE == matricule);

                v.vis_mdp = mdp;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Permet de mettre à jour les informations d'un visiteur grâce à son matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="addr">Adresse du visiteur</param>
        /// <param name="cp">Code Postale du visiteur</param>
        /// <param name="ville">Ville du visiteur</param>
        public void updateVisiteur(String matricule, String addr, String cp, String ville)
        {
            using(var context = new GSB_visite_groupe1Entities())
            {
                var v = context.VISITEUR.First(obj => obj.VIS_MATRICULE == matricule);

                v.VIS_ADRESSE = addr;
                v.VIS_CP = cp;
                v.VIS_VILLE = ville;

                context.SaveChanges();
            }
        }
    }
}
