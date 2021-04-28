using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSBCR.modele;
using GSBCR.BLL;


namespace UnitTestGSBCR.BLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChargerVisiteur()
        {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "visiteur a131 avec mdp 30BFD069 non chargé");

            VISITEUR v2 = VisiteurManager.ChargerVisiteur("a131", "jgjelo");
            Assert.IsNull(v2, "Visiteur a131 à été chargé avec un mdp faux");
        }

        [TestMethod]
        public void TestChargerRapportVisiteurEnCours()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours("a131");

            foreach(RAPPORT_VISITE rapport in lr)
            {
                Assert.AreEqual("a131",rapport.RAP_MATRICULE, "rapport visite n'appartient pas au matricule a131");
                Assert.AreEqual("1", rapport.RAP_ETAT, "état différent de 1");
                ok = rapport.RAP_NUM >= 43 && rapport.RAP_NUM <= 53;
                Assert.IsTrue(ok, "Des problèmes dans les nums de rapports");
            }
            
        }

        [TestMethod]
        public void TestChargerRapportVisiteurFini()
        {
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurFinis("a131");

            foreach(RAPPORT_VISITE rapport in lr)
            {
                Assert.AreEqual("a131", rapport.RAP_MATRICULE, "rapport visite n'appartient pas au matricule a131");
            }
        }
    }
}
