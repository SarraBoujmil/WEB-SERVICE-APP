using Microsoft.AspNetCore.Mvc;

namespace WebApplication1APIREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
       

        private readonly ILogger<PersonneController> _logger;

        public PersonneController(ILogger<PersonneController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{numéro}")]
        public string Get(int numéro)
        {
            //Personne p1= new Personne("Boujmil","Sara");
            //Personne p2 = new Personne("Boujmil", "Amina");  
            //Personne p3 = new Personne("Boujmil", "Hela");
            //Personne p4= new Personne(nom, prénom);

            List<int> listNuméros = new List<int> { 10 ,50,70,100 };
            return listNuméros.Contains(numéro) ? numéro.ToString() : string.Concat(listNuméros);
            _logger.LogInformation("retourne " + listNuméros.Count + " éléments");
            return numéro.ToString();
        }
    }
}
