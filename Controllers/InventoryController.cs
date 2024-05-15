using Microsoft.AspNetCore.Mvc;

namespace ProjetInvtMagasin.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        [HttpGet(Name = "articles")]
        public IEnumerable<Article> GetArticles()
        {
            InventoryService inventoryService = new InventoryService();
            ArticleService articleService = new ArticleService();
            var listArticle = articleService.GenerateArticle();
            _inventoryService.AddArticle(listArticle);
            _inventoryService.displayInventory();

            return listArticle;

        }
    }
    
}
