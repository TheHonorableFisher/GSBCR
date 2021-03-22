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
        public REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            return null;
        }

        public List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            return null;
        }

        public List<REGION> FindBySecteur(string secteurCode)
        {
            //A faire : charger les régions d'un secteur
            return null;
        }
    }
}
