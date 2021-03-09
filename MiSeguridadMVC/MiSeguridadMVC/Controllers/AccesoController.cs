using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiSeguridadMVC.Controllers
{
    //[Authorize] solo personas logueadas pueden acceder las acciones de este controlador
    [Authorize(Users ="correo@correo.com")]
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ContentResult Privado()
        {
            return Content("Esta parte de la web es PRIVADA");
        }
        [AllowAnonymous]
        public ContentResult Publico()
        {
            return Content("Esta parte de la web es PUBLICA");
        }
    }
}