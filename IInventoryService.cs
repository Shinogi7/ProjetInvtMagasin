namespace ProjetInvtMagasin
{
    public interface IInventoryService
    {

        public IEnumerable<Article> GetArticles();
        public void RemoveArticle(int Id);
        public void UpdateArticle(int Id);
        public void AddArticle(List<Article> article);
        public void displayInventory();


    }
}
