using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POOII_EL2_Rodríguez_León_Mitchell.Models
{
    public partial class Vehiculo
    {
        [Display(Name = "Nombre de Marca")]
        public string Marca { get; set; }
    }
}