using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POOII_EL2_Rodríguez_León_Mitchell.Models
{
    public class Viaje
    {
        [Display(Name = "Código de Viaje")]
        public int ViajeId { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        [Display(Name = "Código de Vehículo")]
        public int VehiculoId { get; set; }

        public string Conductor{ get; set; }

        [Display(Name = "Fecha de Partida")]
        public DateTime FechaPartida { get; set; }

        [Display(Name = "Fecha de Llegada")]
        public DateTime FechaLlegada { get; set; }

	}
}