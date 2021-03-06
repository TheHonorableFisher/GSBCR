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
        /// Permet de charger un visiteur à partir de son matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR loadVisiteur(String matricule)
        {
            VISITEUR vis = new VisiteurDAO().FindById(matricule);
            return vis;
        }

        /// <summary>
        /// Permet de mettre à jour le mot de passe d'un visiteur grâce à son matricule.
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="mdp">Nouveau mot de passe du visiteur</param>
        /// <returns>Booléen update (confirmer la modification)</returns>
        public static bool modifierMdp(String matricule, String mdp)
        {
            bool modifier = false;
            try
            {
                new VisiteurDAO().modifierMdp(matricule, mdp);
                modifier = true;
            }
            catch (Exception ex) { throw ex; }

            return modifier;
        }

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
        /// Permet de mettre à jour les informations d'un visiteur grâce à son matricule
        /// </summary>
        /// <param name="mat">Matricule du visiteur</param>
        /// <param name="addr">Adresse du visiteur</param>
        /// <param name="cp">Code Postal du visiteur</param>
        /// <param name="ville">Ville du visiteur</param>
        /// <returns>Booléen update (confirmer la modification)</returns>
        public static bool updateVisiteur(String mat, String addr, String cp, String ville)
        {
            bool update = false;
            try
            {
                new VisiteurDAO().updateVisiteur(mat, addr, cp, ville);
                update = true;
            }
            catch (Exception ex) { throw ex; }

            return update;
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
        /// Permet de charger tout les rapports de visite d'un visite
        /// </summary>
        /// <param name="m">matricule visiteur</param>
        /// <returns></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisite(string m)
        {
            List<RAPPORT_VISITE> r = new RapportVisiteDAO().FindAll(m);
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
        /// Permet de retourner tout les rapports d'un visiteur avec un praticien donné
        /// </summary>
        /// <param name="idPra"></param>
        /// <param name="idVis"></param>
        /// <returns></returns>
        public static List<RAPPORT_VISITE> ChargerRapportParPraticienEtVisiteur(short idPra, string idVis)
        {
            RapportVisiteDAO rapportDAO = new RapportVisiteDAO();
            List<RAPPORT_VISITE> raps = new List<RAPPORT_VISITE>();

            raps = rapportDAO.ChargerRapportParPraticienEtVisiteur(idPra, idVis);
            return raps;
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
        public static PRATICIEN ChargerLePraticien(Int32 pranum)
        {
            PRATICIEN lp = new PratricienDAO().FindById(Convert.ToInt16(pranum));
            return lp;
        }
    }
}
