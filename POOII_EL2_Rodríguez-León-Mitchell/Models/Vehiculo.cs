using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POOII_EL2_Rodríguez_León_Mitchell.Models
{
    public partial class Vehiculo
    {
        [Key]
        [Display(Name = "Código de Vehículo")]
        public int ID { get; set; }
        public string Placa { get; set; }
        public int Año { get; set; }
        public string Modelo { get; set; }

        [Display(Name = "Código de Marca")]
        public int IdMarca { get; set; }
    }
}