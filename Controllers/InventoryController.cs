using Microsoft.AspNetCore.Mvc;

namespace ProjetInvtMagasin.Controllers
{
    public class InventoryController : ControllerBase
    {
        static void Main(string[] args)
        {
            ArticleService articleService = new ArticleService();
            var listAticle = articleService.GenerateArticle();
            InventoryService inventoryService = new InventoryService();
            inventoryService.AddArticle(listAticle);

        }
    }
    
}
