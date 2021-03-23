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
    public class TypePraticienDAO
    {
        /// <summary>
        /// Charge un type de praticien par son code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public TYPE_PRATICIEN FindById(string code)
        {
            // Recherche un type de praticien par son code
            TYPE_PRATICIEN pra = null;
            
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.TYPE_PRATICIEN.Include("LeType")
                          where r.TYP_CODE == code
                          select r;
                pra = req.SingleOrDefault<TYPE_PRATICIEN>();
            }
            return pra;
        }

        /// <summary>
        /// Charge tout les types de praticiens
        /// </summary>
        /// <returns></returns>
        public List<TYPE_PRATICIEN> FindAll()
        {
            // Charge tout les types de praticiens
            List<TYPE_PRATICIEN> pras = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.TYPE_PRATICIEN.Include("LeType")
                          select r;
                pras = req.ToList<TYPE_PRATICIEN>();
            }
            return pras;
        }

    }
}
