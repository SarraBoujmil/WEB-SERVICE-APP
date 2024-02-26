namespace WebApplication1APIREST
{
    public class Personne
    {
        private string nom;
        private string prénom;

        public string Nom { get => nom; set => nom = value; }
        public string Prénom { get => prénom; set => prénom = value; }

        public Personne(string nom, string prénom)
        {
            this.Nom = nom;
            this.Prénom = prénom;
        }
    }
}
