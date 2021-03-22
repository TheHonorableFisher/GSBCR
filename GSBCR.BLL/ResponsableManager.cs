using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;


namespace GSBCR.BLL
{
    public static class ResponsableManager
    {
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un secteur à partir de vaffectation
        /// </summary>
        /// <param name="secteurCode">code secteur</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurBySecteur(string secteurCode)
        {
            //à faire
            //rechercher les régions du secteur
            //pour chaque région, rechercher les visiteurs et délégués
            return null;
        }
    }
}
