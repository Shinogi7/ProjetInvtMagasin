using Microsoft.AspNetCore.Mvc;

namespace ProjetInvtMagasin.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class InventoryController : Controller
    {
        public InventoryController()
        {
                
        }
        [HttpGet(Name = "articles")]
        public IEnumerable<Article> GetArticles()
        {

            InventoryService inventoryService = new InventoryService();
            ArticleService articleService = new ArticleService();
            var listArticle = articleService.GenerateArticle();
            inventoryService.AddArticle(listArticle);
            inventoryService.displayInventory();

            return listArticle.ToArray();

        }
    }
    
}
