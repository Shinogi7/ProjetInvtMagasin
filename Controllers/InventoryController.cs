using Microsoft.AspNetCore.Mvc;

namespace ProjetInvtMagasin.Controllers
{
    public class InventoryController : ControllerBase
    {
        static void Main(string[] args)
        {
            InventoryService inventoryService = new InventoryService();
            ArticleService articleService = new ArticleService();
            var listAticle = articleService.GenerateArticle();            
            inventoryService.AddArticle(listAticle);

        }
    }
    
}
