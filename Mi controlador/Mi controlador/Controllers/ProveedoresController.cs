using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mi_controlador.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public string TodosLosProveedores()
        {
            return @"<ul>
                     <li>Colombina</li>
                     <li>Super</li>
                     <li>Aldor</li>
                     <li>Fini</li>
                    </ul>";
        }
    }
}