using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltro.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        // GET: Home
        public string Index()
        {
            return "Este es mi controlador Home";
        }
        //[Authorize (Roles ="Admin")]//Filtro por rol
        //[OutputCache(Duration =10)] //mantiene la cache por 10sg
        [ActionName("Hora")]//Ponerle nombre a una acción (funciona como seudonimo)
        public string HoraActual() {
            return CadenaHora();
        }

        [NonAction]//no se puede acceder por url    
        public string CadenaHora() {
            return "Son las " + DateTime.Now.ToString("T");
        }
    }
}