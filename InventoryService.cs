﻿namespace ProjetInvtMagasin
{
    public class InventoryService
    {
        public InventoryService() {
            
    }
        public Inventory inventory = new Inventory()
        {
            Id = 1,
            Name = "Test",
            Article = new List<Article>
            {


            }

        };
        public void AddArticle(List<Article> article) 
        {
            inventory.Article.AddRange(article);
        }
        public void RemoveArticle(int Id) { }
        public void UpdateArticle(int Id) { }

        public void displayInventory()
        {
            Console.WriteLine(inventory.Id);
            Console.WriteLine(string.Join(",", inventory.Article.Select(x => x.Name)));

        }
    }
}
