using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manual_inicioUTTT.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public string UTTT()
        {
            return @"<ul>
                     <li>Controlador con acción UTTT en lugar de Index</li>
                     <li>Acciones del controlador</li>
                    </ul>";

                
        }
    }
}