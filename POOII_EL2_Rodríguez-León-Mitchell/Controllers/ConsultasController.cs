using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Namespace Modelo
using POOII_EL2_Rodríguez_León_Mitchell.Models;
// Namespace Configuración
using System.Configuration;
// Namespace Manejo de Datos
using System.Data;
// Namespace Proveedr de SQL
using System.Data.SqlClient;

namespace POOII_EL2_Rodríguez_León_Mitchell.Controllers
{
    public class ConsultasController : Controller
    {

        // Conexión
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNX"].ConnectionString);

        public ActionResult Index()
        {
            return View();
        }
    }
}