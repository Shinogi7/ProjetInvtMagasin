namespace ProjetInvtMagasin
{
    public class ArticleService
    {
        public ArticleService() 
        {
            
        }


        public List<Article> GenerateArticle()
        
        {
            List<Article> articles = new List<Article>();
            articles.Add(new Article() { Id = 1, Name = "Cookie", Price = 1, Quantity = 25 });
            articles.Add(new Article() { Id = 2, Name = "Egg", Price = 0.40, Quantity = 150 });
            articles.Add(new Article() { Id = 3, Name = "Potatoe", Price = 0.28, Quantity = 55});

            return articles;
        
        }
    }
}
