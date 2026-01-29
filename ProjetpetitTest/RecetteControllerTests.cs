using Microsoft.AspNetCore.Mvc;
using S2_5_LePetitProjet.Controllers;


namespace ProjetpetitTest
{
    
    public class RecetteControllerTests
    {
        [Fact]
        public void RecetteControllerTestsRetourneVueRecette()
        {
            RecetteController recetteController = new RecetteController();
            // donc quand ca return un interface le as permet de le cast 
            // pour qu'il soit 
            ViewResult? resultat = recetteController.Index() as ViewResult;
            Assert.Equal("index", resultat.ViewName);
        }
        [Fact]
        public void RecetteControllerTestsModifieTitle()
        {
            RecetteController recetteController = new RecetteController();
            ViewResult? resultat = recetteController.Index() as ViewResult;
            Assert.Equal("index", resultat.ViewName);
        }
    }
}