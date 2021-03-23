using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class DelegueManager
    {
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurByRegion(string regionCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            VISITEUR vis;
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindByRegion(regionCode);
            foreach (VAFFECTATION vaff in lvaff)
            {
                vis = new VisiteurDAO().FindById(vaff.VIS_MATRICULE);
                lv.Add(vis);
            }
            return lv;
        }
        /// <summary>
        /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
        /// </summary>
        /// <param name="code">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(String code)
        {
            // Charger les rapports terminés et non lus (état = 2 ) des visiteurs d'une région
            List<RAPPORT_VISITE> raps = null;

            using(var context = new GSB_visite_groupe1Entities())
            {
                var req = from r in context.RAPPORT_VISITE.Include("Type")
                          where r.RAP_ETAT == "2"
                          select r;
                raps = req.ToList<RAPPORT_VISITE>();
            }

            return raps;
        }
        /// <summary>
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionArchives(String r)
        {
            // Charge les rapports terminés (état = 3) des visiteurs d'une région

            List<RAPPORT_VISITE> raps = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                var req = from rs in context.RAPPORT_VISITE.Include("Type")
                          where rs.RAP_ETAT == "3"
                          select rs;
                raps = req.ToList<RAPPORT_VISITE>();
            }

            return raps;
        }
    }
}
