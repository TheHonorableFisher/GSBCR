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
        public PRATICIEN FindById(Int16 pranum)
        {
            //A faire : rechercher un pratricien par son numéro
            return null;
        }

        public List<PRATICIEN> FindAll()
        {
            List<PRATICIEN> pas = null;
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIEN.Include("LeType")
                          select p;
                pas = req.ToList<PRATICIEN>();

            }
            return pas;
        }

        public List<PRATICIEN> FindByType(string code)
        {
            //A faire : charger tous les praticiens d'un type
            return null;
        }
    }
}
