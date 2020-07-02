using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POOII_EL2_Rodríguez_León_Mitchell.Models
{
    public class Marca
    {
        [Display(Name = "Código de Marca")]
        public int IdMarca { get; set; }
        [Display(Name = "Nombre de Marca")]
        public string Nombre { get; set; }
    }
}