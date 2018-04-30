using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gest_EtatCivil.Models.Personne p = new Gest_EtatCivil.Models.Personne();
            p._AnneeAct = "11111";
            p._Num = "10000";
            Gest_EtatCivil.Metier.AddEtatPersonneMetier aem = Gest_EtatCivil.Metier.AddEtatPersonneMetier();
            aem.AjouterEtat(p);
            //3refti chno fuck it , tal men be3d , aslan ta dinek maradich dir bihom walo db

        }
    }
}
