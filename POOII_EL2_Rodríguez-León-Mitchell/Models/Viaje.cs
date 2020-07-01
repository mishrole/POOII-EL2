using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOII_EL2_Rodríguez_León_Mitchell.Models
{
    public class Viaje
    {
        public int ViajeId { get; set; }
        public string Origen { get; set; }
		public string Destino { get; set; }
        public int VehiculoId { get; set; }
        public string Conductor{ get; set; }
        public DateTime FechaPartida { get; set; }
        public DateTime FechaLlegada { get; set; }

	}
}