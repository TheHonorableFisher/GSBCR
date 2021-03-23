using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class VisiteurManager
    {
         /// <summary>
        /// Permet de charger un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <param name="mdp">mot de passe Visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR ChargerVisiteur(string matricule, string mdp)
        {
            VISITEUR vis = new VisiteurDAO().FindById(matricule);
            if ((vis != null) && (vis.vis_mdp == mdp))
                return vis;
            else
                return null;

        }
        /// <summary>
        /// Permet de charger la dernière affectation du visiteur
        /// et donc son profil (visiteur, délégué, responsabe secteur) et sa région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>objet VAFFECTATION</returns>
        public static VAFFECTATION ChargerAffectationVisiteur(string matricule)
        {
            VAFFECTATION vaff = new VaffectationDAO().FindByMatricule(matricule);
            return vaff;
        }
        /// <summary>
        /// Permet de charger les rapports non terminés du visiteur (état 1)
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurEncours(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(1);
            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return lr;
        }
        /// <summary>
        /// Permet de charger un rapport de visite
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE ChargerRapportVisite(string m, int n)
        {
            RAPPORT_VISITE r = new RapportVisiteDAO().FindById(m, n);
            return r;
        }
        /// <summary>
        /// Permet de charger les rapports terminés du visiteur (état 2 et 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinis(String m)
        {
            // Charge les rapports terminés (état = 2 ou 3) du visiteur
            List<int> etat = new List<int>();
            List<string> matricule = new List<string>();

            etat.Add(2);etat.Add(3);
            matricule.Add(m);

            List<RAPPORT_VISITE> rapports = new RapportVisiteDAO().FindByEtatEtVisiteur(matricule,etat);
            
            return rapports;
        }
        
        /// <summary>
        /// Permet de créer un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void CreateRapport(RAPPORT_VISITE r)
        {
            try
            {
                new RapportVisiteDAO().insert(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void MajRapport(RAPPORT_VISITE r)
        {
            try
            {
                new RapportVisiteDAO().update(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// Permet de charger un médicament à partir de son nom de dépot légal
        /// </summary>
        /// <param name="depot">chaine caractères</param>
        public static MEDICAMENT ChargerLeMedicament(string depot)
        {
            MEDICAMENT l = new MedicamentDAO().FindById(depot);
            return l;
        }
        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        public static List<MEDICAMENT> ChargerMedicaments()
        {
            List<MEDICAMENT> lm = new MedicamentDAO().FindAll();
            return lm;
        }
        /// <summary>
        /// Permet de charger tous les motifs visite
        /// </summary>
        public static List<MOTIF_VISITE> ChargerMotifVisites()
        {
            List<MOTIF_VISITE> lm = new MotifVisiteDAO().FindAll();
            return lm;
        }
        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        public static List<PRATICIEN> ChargerPraticiens()
        {
            List<PRATICIEN> lp = new PratricienDAO().FindAll();
            return lp;
        }
        /// <summary>
        /// Permet de charger un praticien à partir de son numéro
        /// <param name="pranum">entier</param>
        /// </summary>
        public static PRATICIEN ChargerLePraticien(Int16 pranum)
        {
            return null;
        }
    }
}
