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
    public class RapportVisiteDAO
    {
        /// <summary>
        /// Permet de retourner un rapport de visite en connaissant son id
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public RAPPORT_VISITE FindById(string m, int n)
        {
            RAPPORT_VISITE rv =null;
            // écrire et exécuter la requête Linq
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_MATRICULE == m && r.RAP_NUM == n
                          select r;
                rv = req.SingleOrDefault<RAPPORT_VISITE>();
                
            }
            return rv;

        }
        /// <summary>
        /// Permet de retourner tout les rapports de visite d'un visiteur
        /// </summary>
        /// <param name="m">Matricule du visiteur</param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> FindAll(string m)
        {
            List<RAPPORT_VISITE> rv = null;
            // écrire et exécuter la requête Linq
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_MATRICULE == m
                          select r;
                rv = req.ToList<RAPPORT_VISITE>();

            }
            return rv;
        }

        /// <summary>
        /// Permet de créer une liste avec tous les rapports de visite de visiteurs qui ont un certain état
        /// </summary>
        /// <param name="lesMatricules">Liste de matricule (string)</param>
        /// <param name="lesEtats">Liste d'états (int)</param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> FindByEtatEtVisiteur(List<string> lesMatricules, List<int> lesEtats)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            using (var context = new GSB_visite_groupe1Entities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                int i = 0;
                string reqStr = "select * from RAPPORT_VISITE r where r.RAP_MATRICULE in(";
                foreach (string m in lesMatricules)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += "'" + m + "'";
                }
                reqStr += ") and r.RAP_ETAT in(";
                i = 0;
                foreach (int e in lesEtats)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += e ;
                }
                reqStr += ")";
                lesRapports = context.RAPPORT_VISITE.SqlQuery(reqStr).ToList<RAPPORT_VISITE>();
                
            } 
            return lesRapports;
        }

        /// <summary>
        /// Retourne tout les rapports non consulté (état 2) des visiteur d'une région
        /// </summary>
        /// <param name="codeReg">code région</param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> ChargerRapportRegionNonLu(string codeReg)
        {
            List<RAPPORT_VISITE> raps = null;

            using (var context = new GSB_visite_groupe1Entities())
            {
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_ETAT == "2"
                          select r;
                raps = req.ToList<RAPPORT_VISITE>();
            }

            return raps;
        }

        /// <summary>
        ///  Charge les rapports de visite terminé et consulté d'une région et d'un visiteur
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> ChargerRapportRegionArchives(string code)
        {
            List<RAPPORT_VISITE> raps = new List<RAPPORT_VISITE>();

            using (var context = new GSB_visite_groupe1Entities())
            {
                var req = from rs in context.RAPPORT_VISITE
                          where rs.RAP_ETAT == "3"
                          select rs;
                raps = req.ToList<RAPPORT_VISITE>();
            }

            return raps;
        }

        /// <summary>
        /// Permet de retourner tout les rapports d'un visiteurs avec un praticien
        /// </summary>
        /// <param name="idPra"></param>
        /// <param name="idVis"></param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> ChargerRapportParPraticienEtVisiteur(short idPra, string idVis)
        {
            List<RAPPORT_VISITE> raps = new List<RAPPORT_VISITE>();

            using(var context = new GSB_visite_groupe1Entities())
            {
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_PRANUM == idPra && r.RAP_MATRICULE == idVis
                          select r;
                raps = req.ToList<RAPPORT_VISITE>();
            }
            return raps;
        }


        /// <summary>
        /// Permet de créer un rapport dans la base de données par appel de la procédure stockée addRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public void insert(RAPPORT_VISITE r)
        {
            using (var context = new GSB_visite_groupe1Entities())
            {
                try
                {
                    //ajout du rapport au contexte
                    context.RAPPORT_VISITE.Add(r);
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }

        }

         /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données par appel de la procédure stockée updRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public void update(RAPPORT_VISITE r)
        {
            using (var context = new GSB_visite_groupe1Entities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry(r).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
        }


    }
}
