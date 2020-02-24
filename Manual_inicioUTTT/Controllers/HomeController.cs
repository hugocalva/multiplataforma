using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manual_inicioUTTT.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public string Index()
        {
            return "Mi controlador con filtros";
        }
        [ActionName ("hoy")]
        public string Horahoy()
        {
            return horas();
        }
        [NonAction]
        public string horas() { 
        return DateTime.Now.ToString();
        }
    }
}