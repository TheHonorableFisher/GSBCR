using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;

namespace GSBCR.DAL
{
    class SecteurDAO
    {
        /// <summary>
        /// Recherche un secteur par son ID
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public SECTEUR FindById(string code)
        {
            // Recherche un secteur par son ID
            SECTEUR sec = null;

            using(var context = new GSB_visite_groupe1Entities())
            {
                var req = from s in context.SECTEUR.Include("Type")
                          where s.SEC_CODE == code
                          select s;
                sec = req.SingleOrDefault<SECTEUR>();
            }

            return sec;
        }

        public List<SECTEUR> findAll()
        {
            List<SECTEUR> secs = null;
            using(var context = new GSB_visite_groupe1Entities())
            {
                var req = from s in context.SECTEUR.Include("Type")
                          select s;
                secs = req.ToList<SECTEUR>();
            }

            return secs;
        }
    }
}
