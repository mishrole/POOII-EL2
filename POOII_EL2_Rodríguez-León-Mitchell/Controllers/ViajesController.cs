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
    public class ViajesController : Controller
    {

        // Conexión
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CNX"].ConnectionString);

        // Métodos de Acceso a Datos
        List<Viaje> BuscarViajesXAño(int partida)
        {
            List<Viaje> resultado = new List<Viaje>();
            SqlCommand cmd = new SqlCommand("SP_VIAJES_X_PARTIDA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Partida", partida);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Viaje v = new Viaje();
                v.ViajeId = dr.GetInt32(0);
                v.Origen = dr.GetString(1);
                v.Destino = dr.GetString(2);
                v.VehiculoId = dr.GetInt32(3);
                v.Conductor = dr.GetString(4);
                v.FechaPartida = dr.GetDateTime(5);
                v.FechaLlegada = dr.GetDateTime(6);
                resultado.Add(v);

            }

            dr.Close();
            cn.Close();
            return resultado;

        }

        List<Viaje> BuscarViajesXConductorYPartida(string conductor, int partida)
        {
            List<Viaje> resultado = new List<Viaje>();
            SqlCommand cmd = new SqlCommand("SP_VIAJES_X_CONDUCTORYPARTIDA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Conductor", conductor);
            cmd.Parameters.AddWithValue("@Partida", partida);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Viaje v = new Viaje();
                v.ViajeId = dr.GetInt32(0);
                v.Origen = dr.GetString(1);
                v.Destino = dr.GetString(2);
                v.VehiculoId = dr.GetInt32(3);
                v.Conductor = dr.GetString(4);
                v.FechaPartida = dr.GetDateTime(5);
                v.FechaLlegada = dr.GetDateTime(6);
                resultado.Add(v);

            }

            dr.Close();
            cn.Close();
            return resultado;

        }

        List<Viaje> BuscarViajesXVehiculoYPartida(int vehiculo, int partida)
        {
            List<Viaje> resultado = new List<Viaje>();
            SqlCommand cmd = new SqlCommand("SP_VIAJES_X_VEHICULOYPARTIDA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Vehiculo", vehiculo);
            cmd.Parameters.AddWithValue("@Partida", partida);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Viaje v = new Viaje();
                v.ViajeId = dr.GetInt32(0);
                v.Origen = dr.GetString(1);
                v.Destino = dr.GetString(2);
                v.VehiculoId = dr.GetInt32(3);
                v.Conductor = dr.GetString(4);
                v.FechaPartida = dr.GetDateTime(5);
                v.FechaLlegada = dr.GetDateTime(6);
                resultado.Add(v);

            }

            dr.Close();
            cn.Close();
            return resultado;

        }

        // Métodos del Controlador
        public ActionResult BuscarViajesPorAño(int partida = 0)
        {
            List<Viaje> lista = new List<Viaje>();

            if(partida !=  0)
            {
                lista = BuscarViajesXAño(partida);
            }

            return View(lista);
        }

        public ActionResult BuscarViajesPorConductorYPartida(string conductor, int partida = 0)
        {
            List<Viaje> lista = new List<Viaje>();

            if (!string.IsNullOrEmpty(conductor) && partida != 0)
            {
                lista = BuscarViajesXConductorYPartida(conductor, partida);
            }

            return View(lista);
        }

        public ActionResult BuscarViajesPorVehiculoYPartida(int vehiculo = 0, int partida = 0)
        {
            List<Viaje> lista = new List<Viaje>();

            if (vehiculo != 0 && partida != 0)
            {
                lista = BuscarViajesXVehiculoYPartida(vehiculo, partida);
            }

            return View(lista);
        }
    }
}