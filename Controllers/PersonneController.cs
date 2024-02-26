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

        [HttpGet("{num�ro}")]
        public string Get(int num�ro)
        {
            //Personne p1= new Personne("Boujmil","Sara");
            //Personne p2 = new Personne("Boujmil", "Amina");  
            //Personne p3 = new Personne("Boujmil", "Hela");
            //Personne p4= new Personne(nom, pr�nom);

            List<int> listNum�ros = new List<int> { 10 ,50,70,100 };
            return listNum�ros.Contains(num�ro) ? num�ro.ToString() : string.Concat(listNum�ros);
            _logger.LogInformation("retourne " + listNum�ros.Count + " �l�ments");
            return num�ro.ToString();
        }
    }
}
