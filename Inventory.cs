using System.Security.Cryptography.X509Certificates;

namespace ProjetInvtMagasin
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Article> Article { get; set; }

        public Inventory() { }



    }
}
