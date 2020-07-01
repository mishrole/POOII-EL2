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
        public int ID { get; set; }
        public string Placa { get; set; }
        public int Año { get; set; }
        public string Modelo { get; set; }
        public int IdMarca { get; set; }
    }
}