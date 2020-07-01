using POOII_EL2_Rodríguez_León_Mitchell.ADO;
using POOII_EL2_Rodríguez_León_Mitchell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOII_EL2_Rodríguez_León_Mitchell.Controllers
{
    public class VehiculoController : Controller
    {
        MarcaADO adoMarca = new MarcaADO();
        VehiculoADO adoVehiculo = new VehiculoADO();

        public ActionResult ListarVehiculos()
        {
            List<Vehiculo> lista = adoVehiculo.Listar();
            return View(lista);

        }

        public ActionResult RegistrarVehiculo()
        {
            ViewBag.marcas = adoMarca.Listar();
            return View(new Vehiculo());
        }

        [HttpPost]
        public ActionResult RegistrarVehiculo(Vehiculo v)
        {
            int resultado = adoVehiculo.Insertar(v);
            return RedirectToAction("ListarVehiculos");
        }
    }
}